using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class FooterAddress : Entity<Guid>
{
    public string Description { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public FooterAddress() {}
    public FooterAddress(Guid id, string description, string address, string phone, string email) : base(id)
    {
        Description = description;
        Address = address;
        Phone = phone;
        Email = email;
    }
}
