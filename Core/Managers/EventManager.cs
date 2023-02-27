using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers
{ 
    public class EventShowManager
    {
        private List<EventShow> _events;
        public EventShowManager() 
        {
            _events = new List<EventShow>()
            {
                new EventShow() { Id = Guid.NewGuid(), Category = "Music", Name = "Llajta Rock",  EventDate = new DateTime(2023, 05, 25, 15, 0, 0),VenueName = "Felix Capriles", City = "Cochabamba", Country = "Bolivia", TotalCapacity = 35000 },
                new EventShow() { Id = Guid.NewGuid(), Category = "Music", Name = "Download Festival",  EventDate = new DateTime(2023, 06, 8, 16, 0, 0),VenueName = "Donington Park", City = "Leicestershire", Country = "England", TotalCapacity = 111000 },
                new EventShow() { Id = Guid.NewGuid(), Category = "Music", Name = "Tomorrowland",  EventDate = new DateTime(2023, 07, 21, 12, 0, 0),VenueName = "De Schorre park", City = "Boom", Country = "Belgium", TotalCapacity = 200000 },
                new EventShow() { Id = Guid.NewGuid(), Category = "Music", Name = "Lollapalooza",  EventDate = new DateTime(2023, 03, 17, 13, 0, 0),VenueName = "Hipodromo de San Isidro", City = "Buenos Aires", Country = "Argentina", TotalCapacity = 80000 },
                new EventShow() { Id = Guid.NewGuid(), Category = "Sport", Name = "Wilstermann vs Aurora",  EventDate = new DateTime(2023, 02, 12, 19, 30, 0),VenueName = "Felix Capriles", City = "Cochabamba", Country = "Bolivia", TotalCapacity = 35000 },
                new EventShow() { Id = Guid.NewGuid(), Category = "Sport", Name = "River Plate vs Boca Jr",  EventDate = new DateTime(2023, 05, 07, 18, 0, 0),VenueName = "Estadio Monumental", City = "Buenos Aires", Country = "Argentina", TotalCapacity = 83214 },
                new EventShow() { Id = Guid.NewGuid(), Category = "Sport", Name = "WWE WrestleMania 39",  EventDate = new DateTime(2023, 04, 01, 20, 0, 0),VenueName = "SoFi Stadium", City = "Inglewood, California", Country = "USA", TotalCapacity = 90000 },
                new EventShow() { Id = Guid.NewGuid(), Category = "Sport", Name = "FORMULA 1 Rolex Australian Grand Prix 2023",  EventDate = new DateTime(2023, 03, 30, 11, 0, 0),VenueName = "Albert Park Grand Prix Circuit", City = "Melbourne", Country = "Australia", TotalCapacity = 45000 },
            };
        }
        public List<EventShow> GetEvents() 
        { 
            return _events; 
        }
        public EventShow AddEvent(Guid id, string category, string name, DateTime date, string veneName, string city, string country, int capacity)
        {
            EventShow createdEvent = new EventShow() { Id = id, Category = category, Name = name, EventDate = date, VenueName = veneName, City = city, Country = country, TotalCapacity = capacity};
            _events.Add(createdEvent);
            return createdEvent;
        }
        public EventShow UpdateEvent(Guid id, EventShow eventToUpdate)
        {
            EventShow eventFound = _events.Find(ev => ev.Id == id);
            eventFound.EventDate = eventToUpdate.EventDate;
            eventFound.VenueName = eventToUpdate.VenueName;
            eventFound.City = eventToUpdate.City;
            eventFound.Country = eventToUpdate.Country;
            eventFound.TotalCapacity = eventToUpdate.TotalCapacity;
            return eventFound;
        }
        public EventShow DeleteEvent(Guid id) 
        {
            EventShow eventFound = _events.Find(ev => ev.Id == id);
                _events.Remove(eventFound);
                return eventFound;
        }
    }
}
