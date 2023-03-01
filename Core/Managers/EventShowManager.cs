using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Core.Models.DTOs;
using Truextend.TicketDispenser.Core.Managers.Interface;
using AutoMapper;

namespace Truextend.TicketDispenser.Core.Managers;
public class EventShowManager : IEventShowManager
{
    private List<EventShow> _events;
    private readonly VenueManager _venueManager;
    private readonly CategoryManager _categoryManager;
    private readonly ZoneManager _zoneManager;
    private readonly IMapper _mapper;
    public EventShowManager(VenueManager venueManager, CategoryManager categoryManager, ZoneManager zoneManager, IMapper mapper)
    {
        _venueManager = venueManager;
        _categoryManager = categoryManager;
        _zoneManager = zoneManager;
        _mapper = mapper;
        _events = new List<EventShow>()
            {
                new EventShow() {
                    Id = 1,
                    Category = _categoryManager.GetById(1),
                    Name = "Llajta Rock",
                    EventDate = new DateTime(2023, 05, 25, 15, 0, 0),
                    Venue = _venueManager.GetById(1) ,
                    Zones = new List<Zone>()
                }
            };
    }

    public EventShow Create(EventShow item)
    {
        _events.Add(item);
        return item;
    }

    public bool Delete(int id)
    {
        EventShow eventShow = _events.Find(e => e.Id == id);
        return _events.Remove(eventShow);
    }

    public List<EventShow> GetAll()
    {
        return _events;
    }

    public EventShow GetById(int id)
    {
        return _events.Find(e => e.Id == id);
    }

    public EventShow Update(int id, EventShow item)
    {
        throw new NotImplementedException();
    }

    public EventShow UpdateZone(int eventId, int zoneId)
    {
        EventShow eventShow = _events.Find(e => e.Id == eventId);
        Zone zone = _mapper.Map<Zone>(_zoneManager.GetById(zoneId));
        float capacity = eventShow.Venue.TotalCapacity * zone.Percentage;
        zone.Capacity = ((int)capacity);
        eventShow.Zones.Add(zone);
        return eventShow;
    }
}
