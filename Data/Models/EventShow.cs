using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models;
public class EventShow : Entity
{
    public int Id { get; set; }
    public Category Category { get; set; }
    public string Name { get; set; }
    public DateTime EventDate { get; set; }
    public Venue Venue { get; set; }

    public List<Zone> Zones { get; set; }
}
