using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Categories;
using DomainDrivenDesignNet8.Domain.Orders;
using DomainDrivenDesignNet8.Domain.Products;
using DomainDrivenDesignNet8.Domain.Shared;
using DomainDrivenDesignNet8.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesignNet8.Infrastructure.Context;

internal sealed class ApplicationDbContext : DbContext, IUnitOfWork
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DomainDrivenDesignProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
        
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<Name>(); //Name i entity gibi gördüğünden eklendi.

        //ef de Name, Email gibi "value object" 'leri entity olarak tanımlamak yerine, HasConversion yapıldı.
        //value objectlerin db de nasıl tutulması gerektiğini map'ledik.
        modelBuilder.Entity<User>()
            .Property(e => e.Name)
            .HasConversion(name => name.Value, value => new(value)); //db ye yazarken value yaz, alırken new ile al.

        modelBuilder.Entity<User>()
            .Property(e => e.Email)
            .HasConversion(email => email.Value, value => new(value));

        modelBuilder.Entity<User>()
            .Property(e => e.Password)
            .HasConversion(password => password.ToString(), value => new(value));

        //alt class'taki property'leri entity olarak tanımlamak yerine OwnsOne ile birlşştirir. getirirken ayrı verir.
        modelBuilder.Entity<User>()
            .OwnsOne(e=>e.Address);

        modelBuilder.Entity<Category>()
            .Property(e => e.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
            .Property(e => e.Name)
            .HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
            .OwnsOne(e => e.Price, priceBuilder =>
            {
                priceBuilder
                .Property(p=>p.currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                priceBuilder
                .Property(p => p.amount)
                .HasColumnType("money");
            });

        modelBuilder.Entity<OrderLine>()
            .OwnsOne(e => e.Price, priceBuilder =>
            {
                priceBuilder
                .Property(p => p.currency)
                .HasConversion(currency => currency.Code, code => Currency.FromCode(code));

                priceBuilder
                .Property(p => p.amount)
                .HasColumnType("money");
            });
    }
}
