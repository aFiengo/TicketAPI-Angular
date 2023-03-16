
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Data;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class VenueManager : IGenericManager<Venue>
    {
        private readonly IUnitOfWork _uow;

        public VenueManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Venue>> GetAll()
        {
            return await _uow.VenueRepository.GetAllAsync();
        }

        public async Task<Venue> GetById(int id)
        {
            return await _uow.VenueRepository.GetVenueById(id);
        }

        public async Task<Venue> Create(Venue venueToAdd)
        {
            if (String.IsNullOrEmpty(venueToAdd.Name))
            {
                throw new Exception("A name is required");
            }
            if (String.IsNullOrEmpty(venueToAdd.City))
            {
                throw new Exception("A city is required");
            }
            
            return await _uow.VenueRepository.CreateAsync(venueToAdd);
        }
        public async Task<Venue> Update(int id, Venue venueToUpdate)
        {
            Venue venue = await _uow.VenueRepository.GetByIdAsync(id);
            if (venue != null)
            {
                venue.Name = venueToUpdate.Name;
                venue.City = venueToUpdate.City;
                venue.SeatedCapacity = venueToUpdate.SeatedCapacity;
                venue.FieldCapacity = venueToUpdate.FieldCapacity;
                
            }
            return await _uow.VenueRepository.UpdateAsync(venueToUpdate);

        }
        public async Task<bool> Delete(int id)
        {
            Venue venueFound = await _uow.VenueRepository.GetByIdAsync(id);
            await _uow.VenueRepository.DeleteAsync(venueFound);
            return await _uow.VenueRepository.GetByIdAsync(id) == null;

        }

    }
}
