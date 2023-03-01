using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models;
public class Ticket : Entity
{
    public EventShow EventShowName { get; set; }
    public Zone Zone { get; set; }
    public int Quantity { get; set; }
    public User User { get; set; }

}
