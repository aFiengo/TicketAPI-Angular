using Truextend.TicketDispenser.Core.Models.DTOs;

namespace Truextend.TicketDispenser.Core.Models.DTOs;
public class EventShowDTO
{
    public int Id { get; set; }
    public Category Category { get; set; }
    public string Name { get; set; }
    public DateTime EventDate { get; set; }
    public Venue Venue { get; set; }

    public List<ZoneDTO> Zones { get; set; }
}
