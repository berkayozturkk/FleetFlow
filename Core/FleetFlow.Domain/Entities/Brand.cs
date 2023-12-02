using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class Brand : Entity<Guid>
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }

        public Brand(Guid id, string name) : base(id)
        {
            Name = name;
        }
    }
}
