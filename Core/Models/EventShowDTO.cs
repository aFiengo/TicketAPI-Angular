namespace Truextend.TicketDispenser.Core.Models;
public class EventShowDTO
{
    public int Id { get; set; }
    public CategoryDTO Category { get; set; }
    public string Name { get; set; }
    public DateTime EventDate { get; set; }
    public VenueDTO Venue { get; set; }

    public List<ZoneDTO> Zones { get; set; }
}
