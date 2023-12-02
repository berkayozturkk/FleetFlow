using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class Testimonial : Entity<Guid>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }

        public Testimonial(Guid id, string name, string title,
            string comment, string imageUrl) : base()
        {
            Name = name;
            Title = title;
            Comment = comment;
            ImageUrl = imageUrl;
        }
    }
}
