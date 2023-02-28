using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Core.Managers.Base;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class EventShowManager : IGenericManager<EventShow>
    {
        private List<EventShow> _events;
        private VenueManager _venueManager;
        private CategoryManager _categoryManager;
        public EventShowManager(VenueManager venueManager, CategoryManager categoryManager)
        {
            _venueManager = venueManager;
            _categoryManager = categoryManager;
            _events = new List<EventShow>()
            {
                new EventShow() {
                    Id = 1,
                    Category = _categoryManager.GetById(1),
                    Name = "Llajta Rock",
                    EventDate = new DateTime(2023, 05, 25, 15, 0, 0),
                    Venue = _venueManager.GetById(1) 
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
    }
}
