﻿using DomainDrivenDesignNet8.Domain.Abstractions;

namespace DomainDrivenDesignNet8.Domain.Users;

public sealed class User: Entity
{
    public User(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string FullAddress { get; set; }
    public string PostalCode { get; set; }
}
