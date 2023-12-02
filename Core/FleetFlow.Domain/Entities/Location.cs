using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class Location : Entity<Guid>
{
    public string Name { get; set; }

    public Location() {}
    public Location(Guid id, string name) : base(id)
    {
        Name = name;
    }
}
