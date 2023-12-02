using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class Banner : Entity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }

        public Banner(Guid id, string title, string description, string videoDescription, string videoUrl) : base(id)
        {
            Title = title;
            Description = description;
            VideoDescription = videoDescription;
            VideoUrl = videoUrl;
        }
    }
}
