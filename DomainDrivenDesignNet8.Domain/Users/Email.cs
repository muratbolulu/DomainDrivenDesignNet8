namespace DomainDrivenDesignNet8.Domain.Users;

public sealed record Email
{
    public string Value { get; init; }

    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Email cannot be null or empty.");
        }

        if (value.Length < 3)
        {
            throw new ArgumentException("Email must be at least 3 characters long.");
        }

        if (value.Contains('@'))
        {
            throw new ArgumentException("Invalid email");
        }

        Value = value;
    }
}
