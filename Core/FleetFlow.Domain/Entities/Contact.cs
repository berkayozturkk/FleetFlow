using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities
{
    public class Contact : Entity<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }

        public Contact(Guid id, string name, string email, string subject, string message, DateTime sendDate) : base(id)
        {
            Name = name;
            Email = email;
            Subject = subject;
            Message = message;
            SendDate = sendDate;
        }
    }
}
