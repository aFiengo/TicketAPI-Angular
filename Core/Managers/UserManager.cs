using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class UserManager
    {
        private List<User> _users;
        public UserManager() 
        {
            _users = new List<User>()
            {
                new User() { Id = Guid.NewGuid(), FirstName = "Ariel", LastName = "Fiengo", Birthday = new DateOnly(1991,12,22), Email = "ariel.fiengo@gmail.com", CellphoneNumber = 72744409, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = Guid.NewGuid(), FirstName = "Mauricio", LastName = "Terceros", Birthday = new DateOnly(1987,02,7), Email = "mauricio.terceros@gmail.com", CellphoneNumber = 75480016, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = Guid.NewGuid(), FirstName = "Diego", LastName = "Fiengo", Birthday = new DateOnly(1993,10,11), Email = "fiengo.arnez.diego@gmail.com", CellphoneNumber = 71744004, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = Guid.NewGuid(), FirstName = "David", LastName = "Carvajal", Birthday = new DateOnly(1981,12,16), Email = "d.carvajal@gmail.com", CellphoneNumber = 70726199, City = "Cochabamba", Country = "Bolivia"},
            };
        }
        public List<User> GetUsers() 
        {
            return _users;
        }
        public User AddUser(Guid id, string firstName, string lastName, DateOnly birthday, string email, int cellphoneNumber, string city, string country)
        {
            User createdUser = new User() { Id = id, FirstName = firstName, LastName = lastName, Birthday = birthday, Email = email, CellphoneNumber = cellphoneNumber, City = city, Country = country };
            _users.Add(createdUser);
            return createdUser;
        }
        public User UpdateUser(Guid id, User userToUpdate)
        {
            User userFound = _users.Find(u => u.Id == id);
            userFound.FirstName = userToUpdate.FirstName;
            userFound.LastName = userToUpdate.LastName;
            userFound.Birthday = userToUpdate.Birthday;
            userFound.Email = userToUpdate.Email;
            userFound.CellphoneNumber = userToUpdate.CellphoneNumber;
            userFound.City = userToUpdate.City;
            userFound.Country = userToUpdate.Country;
            return userFound;
        }
        public User DeleteUser(Guid id) 
        {
            User userToDelete = _users.Find(u =>u.Id == id);
            _users.Remove(userToDelete);
            return userToDelete;
        }
    }
}
