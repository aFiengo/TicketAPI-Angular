using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Models;
using AutoMapper;
using Truextend.TicketDispenser.Data.Models;
using Truextend.Rewards.Data;

namespace Truextend.TicketDispenser.Core.Managers;
public class ZoneManager : IGenericManager<ZoneDTO>
{
    private List<Zone> _zones;

    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    public ZoneManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _uow = unitOfWork;
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
    public async Task<IEnumerable<ZoneDTO>> GetAll()
    {
        IEnumerable<Zone> zones = await _uow.ZoneRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<ZoneDTO>>(zones);
    }
    public async Task<ZoneDTO> Update(int id, ZoneDTO zoneToUpdate)
    {
        Zone zone = await _uow.ZoneRepository.GetByIdAsync(id);
        _mapper.Map(zoneToUpdate, zone);
        zone.Id = id;
        Zone zoneResponse = await _uow.ZoneRepository.UpdateAsync(zone);
        ZoneDTO editedZone = _mapper.Map<ZoneDTO>(zoneResponse);
        return editedZone;

    }
    public bool Delete(int id)
    {
        if (_zones.Exists(z => z.Id != id))
            return false;
        Zone zoneFound = _zones.Find(z => z.Id == id);
        _zones.Remove(zoneFound);
        return true;
    }

    public async Task<ZoneDTO> GetById(int id)
    {
        Zone zone = await _uow.ZoneRepository.GetByIdAsync(id);
        return _mapper.Map<ZoneDTO>(zone);
    }

    public async Task<ZoneDTO> Create(ZoneDTO item)
    {
        Zone zoneToAdd = _mapper.Map<Zone>(item);
        Zone zoneResponse = await _uow.ZoneRepository.CreateAsync(zoneToAdd);
        return _mapper.Map<ZoneDTO>(zoneResponse);
    }

}