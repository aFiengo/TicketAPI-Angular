using AutoMapper;

using Truextend.TicketDispenser.Core.Managers.Interface;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Managers;
public class EventShowManager
{
    private List<EventShow> _events;
    private readonly ZoneManager _zoneManager;
    private readonly IMapper _mapper;
    public EventShowManager(ZoneManager zoneManager, IMapper mapper)
    {
        _zoneManager = zoneManager;
        _mapper = mapper;
        _events = new List<EventShow>()
            {
                new EventShow() {
                    Id = 1,
                    Category = new Category() {
                        Id = 1,
                        Name = "Music"
                    },
                    Name = "Llajta Rock",
                    EventDate = new DateTime(2023, 05, 25, 15, 0, 0),
                    Venue = new Venue() { 
                        Id = 1, 
                        Name = "Felix Capriles", 
                        City = "Cochabamba", 
                        Country = "Bolivia", 
                        TotalCapacity = 45000
                    },
                    Zones = new List<Zone>()
                }
            };
    }

    public EventShowDTO Create(EventShowDTO item)
    {
        _events.Add(_mapper.Map<EventShow>(item));
        return item;
    }

    public bool Delete(int id)
    {
        EventShow eventShow = _events.Find(e => e.Id == id);
        return _events.Remove(eventShow);
    }

    public IEnumerable<EventShowDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<EventShowDTO>>(_events);
    }

    public EventShowDTO GetById(int id)
    {
        EventShow eventShow = _events.Find(e => e.Id == id);
        return _mapper.Map<EventShowDTO>(eventShow);
    }

    public EventShowDTO Update(int id, EventShowDTO item)
    {
        throw new NotImplementedException();
    }

    public EventShowDTO UpdateZone(int eventId, int zoneId)
    {
        EventShow eventShow = _events.Find(e => e.Id == eventId);
        Zone zone = _mapper.Map<Zone>(_zoneManager.GetById(zoneId));
        float capacity = eventShow.Venue.TotalCapacity * zone.Percentage;
        zone.Capacity = ((int)capacity);
        eventShow.Zones.Add(zone);
        return _mapper.Map<EventShowDTO>(eventShow);
    }
}
