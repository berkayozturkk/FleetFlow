using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class Author : Entity<Guid>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<Blog> Blogs { get; set; }

        public Author(Guid id, string name, string imageUrl, string description) : base(id)
        {
            Name = name;
            ImageUrl = imageUrl;
            Description = description;
        }
    }
}
