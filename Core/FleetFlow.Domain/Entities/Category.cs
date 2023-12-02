using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class Category : Entity<Guid>
    {
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }

        public Category(Guid id, string name) : base(id)
        {
            Name = name;
        }
    }
}
