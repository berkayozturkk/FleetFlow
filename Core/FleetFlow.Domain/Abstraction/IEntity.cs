namespace FleetFlow.Domain.Abstraction
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
