using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class CarDescription : Entity<Guid>
{
    public Guid CarID { get; set; }
    public Car Car { get; set; }
    public string Details { get; set; }

    public CarDescription() {}
    public CarDescription(Guid id, Guid carId, string details) : base(id)
    {
        CarID = carId;
        Details = details;
    }
}
