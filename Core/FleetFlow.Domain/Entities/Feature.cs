using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class Feature : Entity<Guid>
{
    public string Name { get; set; }
    public List<CarFeature> CarFeatures { get; set; }

    public Feature(){}
    public Feature(Guid id, string name) : base(id)
    {
        Name = name;
    }
}
