using Core.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class ZoneManager
    {
        private List<Zone> _zones;
        private VenueManager _venueManager;
        public ZoneManager(VenueManager venueManager) 
        {
            _venueManager = venueManager;
            _zones = new List<Zone>()
            {
                new Zone() {Id = 1, Name = "Butaca", TicketPrice = 130, Capacity = 3000},    //venueManager.GetVenue().Find(v => v.Id ==)
                new Zone() {Id = 2, Name = "Preferencia", TicketPrice = 100, Capacity = 6200},
                new Zone() {Id = 3, Name = "General", TicketPrice = 70, Capacity = 9600},
                new Zone() {Id = 4, Name = "Curva Norte", TicketPrice = 40, Capacity = 6400},
                new Zone() {Id = 5, Name = "Curva Sur", TicketPrice = 40, Capacity = 6400}
            };
        }
        public List<Zone> GetZones() 
        {
            return _zones;
        }
        public Zone AddZone(Zone zoneToAdd, int venueID)
        {
            if(String.IsNullOrEmpty(zoneToAdd.Name)) 
            {
                throw new Exception("A name is required");
            }
            int capacity = _venueManager.GetById(venueID).TotalCapacity * (new Random().Next(1, 100) / 100);
            zoneToAdd.Capacity = capacity;
            _zones.Add(zoneToAdd);
            return zoneToAdd;
        }
        public Zone UpdateZone(int id, Zone zoneToUpdate)
        {
            Zone zone = _zones.FirstOrDefault(z => z.Id == id);
            if (zone != null) 
            {
                zone.Name = zoneToUpdate.Name;
                zone.Capacity = zoneToUpdate.Capacity;
                zone.TicketPrice = zoneToUpdate.TicketPrice;
                
            }
            return zoneToUpdate;
            
        }
        public Zone DeleteZone(int id)
        {
            Zone zoneFound = _zones.Find(z => z.Id == id);
            _zones.Remove(zoneFound);
            return zoneFound;
        }
    }
}
