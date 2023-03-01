using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers;
public class VenueManager
{
    private List<Venue> _venues;
    public VenueManager()
    {
        _venues = new List<Venue>()
            {
                new Venue() { Id = 1, Name = "Felix Capriles", City = "Cochabamba", Country = "Bolivia", TotalCapacity = 45000},
                new Venue() { Id = 2, Name = "Hernando Siles", City = "La Paz", Country = "Bolivia", TotalCapacity = 57000},
                new Venue() { Id = 3, Name = "Ramon 'Tahuichi' Aguilera", City = "Santa Cruz de la Sierra", Country = "Bolivia", TotalCapacity = 49000},
                new Venue() { Id = 4, Name = "Estadio Monumental", City = "Buenos Aires", Country = "Argentina", TotalCapacity = 98214 },
                new Venue() { Id = 5, Name = "Hipodromo de San Isidro", City = "Buenos Aires", Country = "Argentina", TotalCapacity = 98000 },
                new Venue() { Id = 6, Name = "SoFi Stadium", City = "Inglewood, California", Country = "USA", TotalCapacity = 95000},
                new Venue() { Id = 7, Name = "Donington Park", City = "Leicestershire", Country = "England", TotalCapacity = 111000},
                new Venue() { Id = 8, Name = "De Schorre park", City = "Boom", Country = "Belgium", TotalCapacity = 200000 },
                new Venue() { Id = 9, Name = "Albert Park Grand Prix Circuit", City = "Melbourne", Country = "Australia", TotalCapacity = 45000}
            };
    }
    public List<Venue> GetVenue()
    {
        return _venues;
    }
    public Venue Add(Venue venueToAdd)
    {
        if (String.IsNullOrEmpty(venueToAdd.Name))
        {
            throw new Exception("A name is required");
        }
        _venues.Add(venueToAdd);
        return venueToAdd;
    }
    public Venue Update(int id, Venue venueToUpdate)
    {
        Venue venue = _venues.FirstOrDefault(z => z.Id == id);
        if (venue != null)
        {
            venue.Name = venueToUpdate.Name;
            venue.TotalCapacity = venueToUpdate.TotalCapacity;
        }
        return venue;

    }
    public Venue Delete(int id)
    {
        Venue venueFound = _venues.Find(z => z.Id == id);
        _venues.Remove(venueFound);
        return venueFound;
    }
    public Venue GetById(int id)
    {
        Venue selectedVenue = _venues.Find(v => v.Id == id);
        if (selectedVenue == null)
        {
            throw new Exception("Id Not Found");
        }
        return selectedVenue;
    }
}
