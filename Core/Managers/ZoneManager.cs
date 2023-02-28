using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Managers.Interface;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class ZoneManager : IZoneManager
    {
        private List<Zone> _zones;
        private VenueManager _venueManager;
        public ZoneManager(VenueManager venueManager)
        {
            _venueManager = venueManager;
            _zones = new List<Zone>()
            {
                new Zone() {Id = 1, Name = "Butaca", TicketPrice = 130, Capacity = 3000},
                new Zone() {Id = 2, Name = "Preferencia", TicketPrice = 100, Capacity = 6200},
                new Zone() {Id = 3, Name = "General", TicketPrice = 70, Capacity = 9600},
                new Zone() {Id = 4, Name = "Curva Norte", TicketPrice = 40, Capacity = 6400},
                new Zone() {Id = 5, Name = "Curva Sur", TicketPrice = 40, Capacity = 6400}
            };
        }
        public List<Zone> GetAll()
        {
            return _zones;
        }
        public Zone CreateByVenue(int venueID, Zone zoneToAdd)
        {
            if (String.IsNullOrEmpty(zoneToAdd.Name))
            {
                throw new Exception("A name is required");
            }
            Venue selectedVenue = _venueManager.GetById(venueID);
            float capacity = selectedVenue.TotalCapacity * zoneToAdd.Percentage;
            zoneToAdd.Capacity = ((int)capacity);
            _zones.Add(zoneToAdd);
            selectedVenue.Zones.Add(zoneToAdd);
            _venueManager.Update(venueID, selectedVenue);
            return zoneToAdd;
        }
        public Zone Update(int id, Zone zoneToUpdate)
        {
            Zone zone = _zones.FirstOrDefault(z => z.Id == id);
            if (zone != null)
            {
                zone.Name = zoneToUpdate.Name;
                zone.Capacity = zoneToUpdate.Capacity == 0 ? zone.Capacity : zoneToUpdate.Capacity;
                zone.TicketPrice = zoneToUpdate.TicketPrice == 0 ? zone.TicketPrice : zoneToUpdate.TicketPrice;

            }
            return zone;

        }
        public bool Delete(int id)
        {
            if (_zones.Exists(z => z.Id != id))
                return false;
            Zone zoneFound = _zones.Find(z => z.Id == id);
            _zones.Remove(zoneFound);
            return true;
        }

        public Zone GetById(int id)
        {
            return _zones.Find(z => z.Id == id);
        }

        public Zone Create(Zone item)
        {
            throw new NotImplementedException();
        }

    }
}
