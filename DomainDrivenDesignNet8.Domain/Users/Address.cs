namespace DomainDrivenDesignNet8.Domain.Users;

//adress, para tipleri, koordinatlar gibi (kinliği olmayan ve değiştirilemeyen)
public sealed record Address(string Country, string City, string Street, string FullAddress, string PostalCode);
