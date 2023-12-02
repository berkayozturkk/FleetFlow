using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class TagCloud : Entity<Guid>
{
    public string Title { get; set; }
    public Guid BlogId { get; set; }
    public Blog Blog { get; set; }

    public TagCloud() {}
    public TagCloud(Guid id, string title, Guid blogId) : base(id)
    {
        Title = title;
        BlogId = blogId;
    }
}
