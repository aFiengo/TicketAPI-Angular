
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Managers
{ 
    public class EventShowManager
    {
        //private List<EventShow> _events;
        //private CategoryManager _categoryManager;
        //private VenueManager _venueManager;
        //private ZoneManager _zoneManager;
        //public EventShowManager(CategoryManager categoryManager, VenueManager venueManager, ZoneManager zoneManager) 
        //{
        //    _categoryManager = categoryManager;
        //    _venueManager = venueManager;
        //    _zoneManager = zoneManager;

        //    Category selectedCategory = categoryManager.GetCategoryById(1);
        //    if (selectedCategory == null)
        //    {
        //        throw new ArgumentException($"No category found with Id {1}");
        //    }
        //    Venue selectedVenue = venueManager.GetVenueById(1);
        //    if (selectedVenue == null)
        //    {
        //        throw new ArgumentException($"No venue found with Id {1}");
        //    }
        //    List<Zone> selectedZone = zoneManager.GetZones();

        //    _events = new List<EventShow>()
        //    {
        //        new EventShow() { Id = 1, Category = selectedCategory , Name = "Llajta Rock",  EventDate = new DateTime(2023, 05, 25, 15, 0, 0), Location = selectedVenue, Zones = selectedZone},
        //        new EventShow() { Id = 2, Category = selectedCategory, Name = "Download Festival",  EventDate = new DateTime(2023, 06, 8, 16, 0, 0), Location = selectedVenue, Zones = selectedZone},
        //        new EventShow() { Id = 3, Category = selectedCategory, Name = "Tomorrowland",  EventDate = new DateTime(2023, 07, 21, 12, 0, 0), Location = selectedVenue, Zones = selectedZone},
        //        new EventShow() { Id = 4, Category = selectedCategory, Name = "Lollapalooza",  EventDate = new DateTime(2023, 03, 17, 13, 0, 0), Location = selectedVenue, Zones = selectedZone},
        //        new EventShow() { Id = 5, Category = selectedCategory, Name = "Wilstermann vs Aurora",  EventDate = new DateTime(2023, 02, 12, 19, 30, 0), Location = selectedVenue, Zones = selectedZone},
        //        new EventShow() { Id = 6, Category = selectedCategory, Name = "River Plate vs Boca Jr",  EventDate = new DateTime(2023, 05, 07, 18, 0, 0), Location = selectedVenue, Zones = selectedZone},
        //        new EventShow() { Id = 7, Category = selectedCategory, Name = "WWE WrestleMania 39",  EventDate = new DateTime(2023, 04, 01, 20, 0, 0), Location = selectedVenue, Zones = selectedZone},
        //        new EventShow() { Id = 8, Category = selectedCategory, Name = "FORMULA 1 Rolex Australian Grand Prix 2023",  EventDate = new DateTime(2023, 03, 30, 11, 0, 0), Location = selectedVenue, Zones = selectedZone},
        //    };
        //}
        //public List<EventShow> GetEvents() 
        //{ 
        //    return _events; 
        //}
        //public EventShow AddEvent(EventShow eventToAdd, int categoryId, int venueId)
        //{
        //    if (String.IsNullOrEmpty(eventToAdd.Name))
        //    {
        //        throw new Exception("A name is required");
        //    }
        //    var selectedCategory = _categoryManager.GetCategoryById(categoryId);
        //    if (selectedCategory == null)
        //    {
        //        throw new ArgumentException($"No category found with Id {categoryId}");
        //    }
        //    var selectedVenue = _venueManager.GetVenueById(venueId);
        //    if (selectedVenue == null)
        //    {
        //        throw new ArgumentException($"No venue found with Id {venueId}");
        //    }
        //    _events.Add(eventToAdd);
        //    return eventToAdd;
        //}
        //public EventShow UpdateEventById(int id, EventShow eventToUpdate)
        //{
        //    EventShow eventFound = _events.Find(ev => ev.Id == id);
        //    if (eventFound == null)
        //    {
        //        eventFound.Category = eventToUpdate.Category;
        //        eventFound.Name = eventToUpdate.Name;
        //        eventFound.EventDate = eventToUpdate.EventDate;
        //        eventFound.Location = eventToUpdate.Location;
        //    }
        //    return eventFound;
        //}
        //public EventShow DeleteEventById(int id) 
        //{
        //    EventShow eventFound = _events.Find(ev => ev.Id == id);
        //        _events.Remove(eventFound);
        //        return eventFound;
        //}
        //public EventShow GetEventById(int id)
        //{
        //    EventShow selectedEvent = _events.Find(z => z.Id == id);
        //    if (selectedEvent == null)
        //    {
        //        throw new Exception("Id Not Found");
        //    }
        //    return selectedEvent;
        //}
    }
}
