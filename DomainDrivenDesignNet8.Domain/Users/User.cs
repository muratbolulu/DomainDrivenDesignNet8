﻿using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Shared;

namespace DomainDrivenDesignNet8.Domain.Users;

public sealed class User : Entity
{
    //public yerine private a dönüştürür ve User oluşturma işini contractor'dan alıp static bir metoda veririz.
    //factory pattern (proje ihtiyacına göre)
    private User(Guid id, Name name, Name surname, Email email, string password, Address address):base(id)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
        Address = address;
    }

    private User(Guid id) : base(id)
    {
    }

    public Name Name { get; private set; }
    public Name Surname { get; private set; }
    public Email Email { get; private set; }
    public string Password { get; private set; }
    public Address Address { get; private set; }

    public static User CreateUser(string name, string surname, string email, string password, 
                                  string country, string city, string street, string fullAddress, string postalCode)
    {
        //public yerine private a dönüştürür ve User oluşturma işini contractor'dan alıp static bir metoda veririz.
        //factory pattern (proje ihtiyacına göre)
        User user = new(Guid.NewGuid(), new Name(name), new Name(surname), new Email(email), password,
                                        new Address(country, city, street, fullAddress, postalCode));

        return user;
    }

    public void ChangeName(Name name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }
        Name = name;
    }

    public void ChangeEmail(Email email)
    {
        if (email is null)
        {
            throw new ArgumentNullException(nameof(email));
        }
        Email = email;
    }

    public void ChangeAddress(string country, string city, string street, string fullAddress, string postalCode)
    {
        Address = new(country,city,street,fullAddress,postalCode);
    }

    public void ChangePassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentNullException(nameof(password));
        }

        Password = new(password);
    }
}
