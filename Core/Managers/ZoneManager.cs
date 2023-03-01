using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Models.DTOs;
using Truextend.TicketDispenser.Core.Models;
using AutoMapper;

namespace Truextend.TicketDispenser.Core.Managers;
public class ZoneManager : IGenericManager<ZoneDTO>
{
    private List<Zone> _zones;
    private readonly IMapper _mapper;
    public ZoneManager(IMapper mapper)
    {
        _mapper = mapper;
        _zones = new List<Zone>()
            {
                new Zone() {Id = 1, Name = "Butaca", TicketPrice = 130, Capacity = 3000},
                new Zone() {Id = 2, Name = "Preferencia", TicketPrice = 100, Capacity = 6200},
                new Zone() {Id = 3, Name = "General", TicketPrice = 70, Capacity = 9600},
                new Zone() {Id = 4, Name = "Curva Norte", TicketPrice = 40, Capacity = 6400},
                new Zone() {Id = 5, Name = "Curva Sur", TicketPrice = 40, Capacity = 6400}
            };
    }
    public List<ZoneDTO> GetAll()
    {
        return _mapper.Map<List<ZoneDTO>>(_zones);
    }
    public ZoneDTO Update(int id, ZoneDTO zoneToUpdate)
    {
        Zone zone = _zones.FirstOrDefault(z => z.Id == id);
        if (zone != null)
        {
            zone.Name = zoneToUpdate.Name;
            zone.TicketPrice = zoneToUpdate.TicketPrice == 0 ? zone.TicketPrice : zoneToUpdate.TicketPrice;

        }
        return _mapper.Map<ZoneDTO>(zone);

    }
    public bool Delete(int id)
    {
        if (_zones.Exists(z => z.Id != id))
            return false;
        Zone zoneFound = _zones.Find(z => z.Id == id);
        _zones.Remove(zoneFound);
        return true;
    }

    public ZoneDTO GetById(int id)
    {
        Zone selectedZone = _zones.Find(z => z.Id == id);
        return _mapper.Map<ZoneDTO>(selectedZone);
    }

    public ZoneDTO Create(ZoneDTO item)
    {
        Zone zoneToAdd = _mapper.Map<Zone>(item);
        _zones.Add(zoneToAdd);
        return item;
    }

}