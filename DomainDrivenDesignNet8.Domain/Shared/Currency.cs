
namespace DomainDrivenDesignNet8.Domain.Shared;

public sealed record Currency
{
    public static readonly Currency TRY = new("TRY");
    public static readonly Currency USD = new("USD");
    public static readonly Currency EUR = new("EUR");
    internal static readonly Currency None = new("");

    private Currency(string code)
    {
        Code = code;
    }

    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase))
               ?? throw new ArgumentException($"Currency {code} is not supported.");
    }

    public static readonly Currency[] All = { TRY, USD, EUR };
}
