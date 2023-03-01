using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models;
public class Venue : Entity
{
    public string Name { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public int TotalCapacity { get; set; }
}