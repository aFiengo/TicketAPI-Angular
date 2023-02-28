using Core.Models;
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
                new User() { Id = 1, FirstName = "Ariel", LastName = "Fiengo", Birthday = new DateOnly(1991,12,22), Email = "ariel.fiengo@gmail.com", CellphoneNumber = 72744409, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = 2, FirstName = "Mauricio", LastName = "Terceros", Birthday = new DateOnly(1987,02,7), Email = "mauricio.terceros@gmail.com", CellphoneNumber = 75480016, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = 3, FirstName = "Diego", LastName = "Fiengo", Birthday = new DateOnly(1993,10,11), Email = "fiengo.arnez.diego@gmail.com", CellphoneNumber = 71744004, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = 4, FirstName = "David", LastName = "Carvajal", Birthday = new DateOnly(1981,12,16), Email = "d.carvajal@gmail.com", CellphoneNumber = 70726199, City = "Cochabamba", Country = "Bolivia"},
            };
        }
        public List<User> GetUsers() 
        {
            return _users;
        }
        public User AddUser(User userToAdd)
        {
            if (String.IsNullOrEmpty(userToAdd.FirstName))
            {
                throw new Exception("A first name is required");
            }
            if (String.IsNullOrEmpty(userToAdd.LastName))
            {
                throw new Exception("A last name is required");
            }
            if (String.IsNullOrEmpty(userToAdd.Email))
            {
                throw new Exception("An e-mail is required");
            }
            _users.Add(userToAdd);
            return userToAdd;
        }
        public User UpdateUser(int id, User userToUpdate)
        {
            User userFound = _users.FirstOrDefault(u => u.Id == id);
            if (userFound != null)
            {
                userFound.FirstName = userToUpdate.FirstName;
                userFound.LastName = userToUpdate.LastName;
                userFound.Birthday = userToUpdate.Birthday;
                userFound.Email = userToUpdate.Email;
                userFound.CellphoneNumber = userToUpdate.CellphoneNumber;
                userFound.City = userToUpdate.City;
                userFound.Country = userToUpdate.Country;
            }
            return userToUpdate;
        }
        public User DeleteUser(int id) 
        {
            User userToDelete = _users.Find(u =>u.Id == id);
            _users.Remove(userToDelete);
            return userToDelete;
        }
        public User GetById(int id)
        {
            User selectedUser = _users.Find(z => z.Id == id);
            if (selectedUser == null)
            {
                throw new Exception("Id Not Found");
            }
            return selectedUser;
        }
    }
}
