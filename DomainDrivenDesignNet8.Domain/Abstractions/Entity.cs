
namespace DomainDrivenDesignNet8.Domain.Abstractions;

public abstract class Entity :IEquatable<Entity>
{
    public Guid Id { get; init; }

    protected Entity(Guid id)
    {
        Id = id;
    }

    //nesne equals. daha yavaş IEquatable a göre
    public override bool Equals(object? obj)
    {
        if(obj is null)
        {
            return false;
        }

        if(obj is not Entity entity)
        {
            return false;
        }

        if (obj.GetType() != GetType()){
            return false;
        }

        return entity.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    //IEquatable equals 
    public bool Equals(Entity? other)
    {
        if (other is null)
        {
            return false;
        }

        if (other is not Entity entity)
        {
            return false;
        }

        if (other.GetType() != GetType())
        {
            return false;
        }

        return entity.Id == Id;
    }
}
