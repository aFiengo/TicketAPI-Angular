namespace Truextend.TicketDispenser.Core.Models;
public class Ticket
{
    public int Id { get; set; }
    public EventShow EventShowName { get; set; }
    public Zone Zone { get; set; }
    public int Quantity { get; set; }
    public User User { get; set; }

}
