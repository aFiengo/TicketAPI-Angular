
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
            Venue selectedVenue = venueManager.GetVenueById(1);
            if (selectedVenue == null)
            {
                throw new ArgumentException($"No venue found with Id {1}");
            }
            _venueManager = venueManager;
            _zones = new List<Zone>()
            {
                new Zone() {Id = 1, Name = "Butaca", TicketPrice = 130, CapPorcentage = 0.05f},    //% de butacas es 5% del total 
                new Zone() {Id = 2, Name = "Preferencia", TicketPrice = 100, CapPorcentage = 0.27f},  //% es 27% del total
                new Zone() {Id = 3, Name = "General", TicketPrice = 70, CapPorcentage = 0.32f},  //% es 32% del total
                new Zone() {Id = 4, Name = "Curva Norte", TicketPrice = 40, CapPorcentage = 0.18f},  //% es 18% del total
                new Zone() {Id = 5, Name = "Curva Sur", TicketPrice = 40, CapPorcentage = 0.18f},  //% es 18% del total
                new Zone() {Id = 6, Name = "Super VIP", TicketPrice = 1200, CapPorcentage = 0.2f},
                new Zone() {Id = 7, Name = "VIP", TicketPrice = 900, CapPorcentage = 0.3f},
                new Zone() {Id = 8, Name = "Pista", TicketPrice = 500, CapPorcentage = 0.5f}
            };
        }
        public List<Zone> GetZones() 
        {
            return _zones;
        }
        public Zone AddZone(Zone zoneToAdd, int venueId, float porcentage)
        {
            if(String.IsNullOrEmpty(zoneToAdd.Name)) 
            {
                throw new Exception("A name is required");
            }
            var selectedVenue = _venueManager.GetVenueById(venueId);
            if (selectedVenue == null)
            {
                throw new ArgumentException($"No venue found with Id {venueId}");
            }
            _zones.Add(zoneToAdd);
            return zoneToAdd;
        }
        public Zone UpdateZoneById(int id, Zone zoneToUpdate)
        {
            Zone zone = _zones.FirstOrDefault(z => z.Id == id);
            if (zone != null) 
            {
                zone.Name = zoneToUpdate.Name;
                zone.CapPorcentage = zoneToUpdate.CapPorcentage;
                zone.TicketPrice = zoneToUpdate.TicketPrice;
                
            }
            return zoneToUpdate;
            
        }
        public Zone DeleteZoneById(int id)
        {
            Zone zoneFound = _zones.Find(z => z.Id == id);
            _zones.Remove(zoneFound);
            return zoneFound;
        }
        public Zone GetZoneById(int id)
        {
            Zone selectedZone = _zones.Find(z => z.Id == id);
            if (selectedZone == null)
            {
                throw new Exception("Id Not Found");
            }
            return selectedZone;
        }
    }
}
