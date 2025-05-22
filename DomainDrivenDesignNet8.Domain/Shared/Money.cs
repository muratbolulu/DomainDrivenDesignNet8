
namespace DomainDrivenDesignNet8.Domain.Shared;

public sealed record Money(decimal amount, Currency currency)
{
    public static Money operator +(Money a, Money b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException($"Cannot add {a.currency.Code} to {b.currency.Code}");
        }
        return new Money(a.amount + b.amount, a.currency);
    }
    public static Money operator -(Money a, Money b)
    {
        if (a.currency != b.currency)
        {
            throw new ArgumentException($"Cannot subtract {a.currency.Code} from {b.currency.Code}");
        }
        return new Money(a.amount - b.amount, a.currency);
    }

    public static Money Zero()=> new Money(0, Currency.None);
    public static Money Zero(Currency currency)=> new Money(0, currency);

    public bool IsZero() => this == Zero(currency);
   
}
