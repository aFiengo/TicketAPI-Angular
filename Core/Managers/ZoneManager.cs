
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Data;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class ZoneManager : IGenericManager<Zone>
    {
        private readonly IUnitOfWork _uow;

        public ZoneManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Zone>> GetAll()
        {
            try
            {
                IEnumerable<Zone> zones = await _uow.ZoneRepository.GetAllAsync();
                return await _uow.ZoneRepository.GetAllAsync();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public async Task<Zone> GetById(int id)
        {
            return await _uow.ZoneRepository.GetZoneById(id);
        }
        public async Task<ZoneVenue> GetByVenueId(int venueId)
        {
            return await _uow.ZoneVenueRepository.GetZoneByVenueId(venueId);
        }
        public async Task<Zone> Create(Zone zoneToAdd)
        {
            if (String.IsNullOrEmpty(zoneToAdd.Name))
            {
                throw new Exception("A name is required");
            }

            return await _uow.ZoneRepository.CreateAsync(zoneToAdd);
        }
        public async Task<Zone> Update(int id, Zone zoneToUpdate)
        {
            Zone zone = await _uow.ZoneRepository.GetByIdAsync(id);
            if (zone != null)
            {
                zone.Name = zoneToUpdate.Name;
                zone.TicketPrice = zoneToUpdate.TicketPrice;
                zone.CapPorcentage = zoneToUpdate.CapPorcentage;
            }
            return await _uow.ZoneRepository.UpdateAsync(zoneToUpdate);

        }
        public async Task<bool> Delete(int id)
        {
            Zone zoneFound = await _uow.ZoneRepository.GetByIdAsync(id);
            await _uow.ZoneRepository.DeleteAsync(zoneFound);
            return await _uow.ZoneRepository.GetByIdAsync(id) == null;

        }
    }
}
