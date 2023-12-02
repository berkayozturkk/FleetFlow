using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class TagCloud : Entity<Guid>
    {
        public string Title { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

        public TagCloud(Guid id, string title, int blogId) : base(id)
        {
            Title = title;
            BlogID = blogId;
        }
    }
}
