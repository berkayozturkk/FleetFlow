using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class CarPricing : Entity<Guid>
{
    public Guid CarID { get; set; }
    public Car Car { get; set; }
    public Guid PricingID { get; set; }
    public Pricing Pricing { get; set; }
    public decimal Amount { get; set; }

    public CarPricing() {}
    public CarPricing(Guid id, Guid carId, Guid pricingId, decimal amount) : base(id)
    {
        CarID = carId;
        PricingID = pricingId;
        Amount = amount;
    }
}
