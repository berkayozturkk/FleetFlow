using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class CarFeature : Entity<Guid>
    {
        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public Guid FeatureID { get; set; }
        public Feature Feature { get; set; }
        public bool Available { get; set; }

        public CarFeature(Guid id, Guid carId, Guid featureId, bool available) : base(id)
        {
            CarID = carId;
            FeatureID = featureId;
            Available = available;
        }
    }
}
