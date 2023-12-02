using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class Comment : Entity<Guid>
{
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Description { get; set; }
    public Guid BlogID { get; set; }
    public Blog Blog { get; set; }

    public Comment() {}
    public Comment(Guid id, string name, DateTime createdDate, string description, Guid blogId) : base(id)
    {
        Name = name;
        CreatedDate = createdDate;
        Description = description;
        BlogID = blogId;
    }
}
