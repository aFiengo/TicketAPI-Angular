
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
    public class EventShowManager : IGenericManager<EventShow>
    {
        private readonly IUnitOfWork _uow;

        public EventShowManager(IUnitOfWork uow)
        {
            _uow = uow;

        }
        public async Task<IEnumerable<EventShow>> GetAll()
        {
            return await _uow.EventRepository.GetAllEvents();
            
        }
        public async Task<EventShow> GetById(int id)
        {
            return await _uow.EventRepository.GetEventById(id);
        }
        public async Task<EventShow> Create(EventShow eventToAdd)
        {
            if (String.IsNullOrEmpty(eventToAdd.Name))
            {
                throw new Exception("A first name is required");
            }
            return await _uow.EventRepository.CreateAsync(eventToAdd);
        }
        public async Task<EventShow> Update(int id, EventShow eventToUpdate)
        {
            EventShow eventFound = await _uow.EventRepository.GetByIdAsync(id);
            if (eventFound != null)
            {
                eventFound.Name = eventToUpdate.Name;
                eventFound.EventDate = eventToUpdate.EventDate;
            }
            return await _uow.EventRepository.UpdateAsync(eventToUpdate);
        }
        public async Task<bool> Delete(int id)
        {
            EventShow eventFound = await _uow.EventRepository.GetByIdAsync(id);
            await _uow.EventRepository.DeleteAsync(eventFound);
            return await _uow.EventRepository.GetByIdAsync(id) == null;

        }
    }
}
