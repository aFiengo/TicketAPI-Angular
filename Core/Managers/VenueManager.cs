
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class VenueManager
    {
        private List<Venue> _venues;
        public VenueManager() 
        {
            _venues = new List<Venue>()
            {
                new Venue() { Id = 1, Name = "Felix Capriles", City = "Cochabamba", Country = "Bolivia", SeatedCapacity = 35000, FieldCapacity = 10000},
                new Venue() { Id = 2, Name = "Hernando Siles", City = "La Paz", Country = "Bolivia", SeatedCapacity = 42000, FieldCapacity = 12000},
                new Venue() { Id = 3, Name = "Ramon 'Tahuichi' Aguilera", City = "Santa Cruz de la Sierra", Country = "Bolivia", SeatedCapacity = 38000, FieldCapacity = 11000},
                new Venue() { Id = 4, Name = "Estadio Monumental", City = "Buenos Aires", Country = "Argentina", SeatedCapacity = 83214, FieldCapacity = 15000},
                new Venue() { Id = 5, Name = "Hipodromo de San Isidro", City = "Buenos Aires", Country = "Argentina", SeatedCapacity = 18000, FieldCapacity = 80000},
                new Venue() { Id = 6, Name = "SoFi Stadium", City = "Inglewood, California", Country = "USA", SeatedCapacity = 90000, FieldCapacity = 5000},
                new Venue() { Id = 7, Name = "Donington Park", City = "Leicestershire", Country = "England", SeatedCapacity = 0 , FieldCapacity = 110000},
                new Venue() { Id = 8, Name = "De Schorre park", City = "Boom", Country = "Belgium", SeatedCapacity = 0, FieldCapacity = 200000 },
                new Venue() { Id = 9, Name = "Albert Park Grand Prix Circuit", City = "Melbourne", Country = "Australia", SeatedCapacity = 45000, FieldCapacity = 0}
            };
        }
        public List<Venue> GetVenues()
        {
            return _venues;
        }
        public Venue AddVenue(Venue venueToAdd)
        {
            if (String.IsNullOrEmpty(venueToAdd.Name))
            {
                throw new Exception("A name is required");
            }
            _venues.Add(venueToAdd);
            return venueToAdd;
        }
        public Venue UpdateVenueById(int id, Venue venueToUpdate)
        {
            Venue venue = _venues.FirstOrDefault(z => z.Id == id);
            if (venue != null)
            {
                venue.Name = venueToUpdate.Name;
                venue.SeatedCapacity = venueToUpdate.SeatedCapacity;
                venue.FieldCapacity = venueToUpdate.FieldCapacity;
                
            }
            return venueToUpdate;

        }
        public Venue DeleteVenueById(int id) //ById
        {
            Venue venueFound = _venues.Find(z => z.Id == id);
            _venues.Remove(venueFound);
            return venueFound;
        }
        public Venue GetVenueById(int id)
        {
            Venue selectedVenue = _venues.Find(z => z.Id == id);
            if(selectedVenue == null) 
            {
                throw new Exception("Id Not Found");
            }
            return selectedVenue;
         }
    }
}
