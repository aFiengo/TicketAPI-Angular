using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;

namespace Core.Managers
{
    public class VenueManager
    {
        private List<VenueModel> _venues;
        public VenueManager() 
        {
            _venues = new List<VenueModel>()
            {
                new VenueModel() { Id = 1, Name = "Felix Capriles", City = "Cochabamba", Country = "Bolivia", SeatedCapacity = 35000, FieldCapacity = 10000, TotalCapacity = 45000},
                new VenueModel() { Id = 2, Name = "Hernando Siles", City = "La Paz", Country = "Bolivia", SeatedCapacity = 42000, FieldCapacity = 12000, TotalCapacity = 57000},
                new VenueModel() { Id = 3, Name = "Ramon 'Tahuichi' Aguilera", City = "Santa Cruz de la Sierra", Country = "Bolivia", SeatedCapacity = 38000, FieldCapacity = 11000, TotalCapacity = 49000},
                new VenueModel() { Id = 4, Name = "Estadio Monumental", City = "Buenos Aires", Country = "Argentina", SeatedCapacity = 83214, FieldCapacity = 15000 , TotalCapacity = 98214 },
                new VenueModel() { Id = 5, Name = "Hipodromo de San Isidro", City = "Buenos Aires", Country = "Argentina", SeatedCapacity = 18000, FieldCapacity = 80000, TotalCapacity = 98000 },
                new VenueModel() { Id = 6, Name = "SoFi Stadium", City = "Inglewood, California", Country = "USA", SeatedCapacity = 90000, FieldCapacity = 5000, TotalCapacity = 95000},
                new VenueModel() { Id = 7, Name = "Donington Park", City = "Leicestershire", Country = "England", SeatedCapacity = 0 , FieldCapacity = 110000, TotalCapacity = 111000},
                new VenueModel() { Id = 8, Name = "De Schorre park", City = "Boom", Country = "Belgium", SeatedCapacity = 0, FieldCapacity = 200000, TotalCapacity = 200000 },
                new VenueModel() { Id = 9, Name = "Albert Park Grand Prix Circuit", City = "Melbourne", Country = "Australia", SeatedCapacity = 45000, FieldCapacity = 0, TotalCapacity = 45000}
            };
        }
        public List<VenueModel> GetVenue()
        {
            return _venues;
        }
        public VenueModel AddVenue(VenueModel venueToAdd)
        {
            if (String.IsNullOrEmpty(venueToAdd.Name))
            {
                throw new Exception("A name is required");
            }
            _venues.Add(venueToAdd);
            return venueToAdd;
        }
        public VenueModel UpdateZone(int id, VenueModel venueToUpdate)
        {
            VenueModel venue = _venues.FirstOrDefault(z => z.Id == id);
            if (venue != null)
            {
                venue.Name = venueToUpdate.Name;
                venue.SeatedCapacity = venueToUpdate.SeatedCapacity;
                venue.FieldCapacity = venueToUpdate.FieldCapacity;
                venue.TotalCapacity = venueToUpdate.TotalCapacity;
            }
            return venueToUpdate;

        }
        public VenueModel DeleteZone(int id)
        {
            VenueModel venueFound = _venues.Find(z => z.Id == id);
            _venues.Remove(venueFound);
            return venueFound;
        }
        public VenueModel GetById(int id)
        {
            VenueModel selectedVenue = _venues.Find(z => z.Id == id);
            if(selectedVenue == null) 
            {
                throw new Exception("Id Not Found");
            }
            return selectedVenue;
         }
    }
}
