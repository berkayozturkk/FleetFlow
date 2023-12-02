using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class SocialMedia : Entity<Guid>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public SocialMedia(Guid id, string name, string url, string icon) : base(id)
        {
            Name = name;
            Url = url;
            Icon = icon;
        }
    }
}
