using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class About : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public About() {}
    public About(Guid id, string title,
        string description, string imageUrl) : base(id)
    {
        Title = title;
        Description = description;
        ImageUrl = imageUrl;
    }
}
