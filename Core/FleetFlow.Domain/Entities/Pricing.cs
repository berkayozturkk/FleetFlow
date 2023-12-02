using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class Pricing : Entity<Guid>
{
    public string Name { get; set; }
    public List<CarPricing> CarPricings { get; set; }

    public Pricing() {}
    public Pricing(Guid id, string name) : base(id)
    {
        Name = name;
    }
}
