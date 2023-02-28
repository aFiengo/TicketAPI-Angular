
using Core.Models;
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
            Venue selectedVenue = venueManager.GetById(1);
            if (selectedVenue == null)
            {
                throw new ArgumentException($"No venue found with Id {1}");
            }
            _venueManager = venueManager;
            _zones = new List<Zone>()
            {
                new Zone() {Id = 1, Name = "Butaca", TicketPrice = 130, CapPorcentage = 0.05f ,Capacity = (int)(selectedVenue.SeatedCapacity * 0.05)},    //% de butacas es 5% del total 
                new Zone() {Id = 2, Name = "Preferencia", TicketPrice = 100, CapPorcentage = 0.27f,Capacity = (int)(selectedVenue.SeatedCapacity * 0.27)},  //% es 27% del total
                new Zone() {Id = 3, Name = "General", TicketPrice = 70, CapPorcentage = 0.32f ,Capacity = (int)(selectedVenue.SeatedCapacity * 0.32)},  //% es 32% del total
                new Zone() {Id = 4, Name = "Curva Norte", TicketPrice = 40, CapPorcentage = 0.18f, Capacity = (int)(selectedVenue.SeatedCapacity * 0.18)},  //% es 18% del total
                new Zone() {Id = 5, Name = "Curva Sur", TicketPrice = 40, CapPorcentage = 0.18f, Capacity = (int)(selectedVenue.SeatedCapacity * 0.18)},  //% es 18% del total
                new Zone() {Id = 6, Name = "Super VIP", TicketPrice = 1200, CapPorcentage = 0.2f, Capacity = (int)(selectedVenue.FieldCapacity * .2)},
                new Zone() {Id = 7, Name = "VIP", TicketPrice = 900, CapPorcentage = 0.3f, Capacity = (int)(selectedVenue.FieldCapacity * .3)},
                new Zone() {Id = 8, Name = "Pista", TicketPrice = 500, CapPorcentage = 0.5f, Capacity = (int)(selectedVenue.FieldCapacity * .5)}
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
            var selectedVenue = _venueManager.GetById(venueId);
            if (selectedVenue == null)
            {
                throw new ArgumentException($"No venue found with Id {venueId}");
            }
            int capacity = (int)(selectedVenue.TotalCapacity * porcentage);
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
                zone.CapPorcentage = zoneToUpdate.CapPorcentage;
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
        public Zone GetById(int id)
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
