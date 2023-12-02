using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class Service : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string IconUrl { get; set; }

    public Service() {}
    public Service(Guid id, string title, string description, string iconUrl) : base(id)
    {
        Title = title;
        Description = description;
        IconUrl = iconUrl;
    }
}
