using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.Core.Managers;
public class UserManager : IGenericManager<User>
{
    private List<User> _users;
    public UserManager()
    {
        _users = new List<User>()
            {
                new User() { Id = 1, FirstName = "Ariel", LastName = "Fiengo", Birthday = new DateTime(1991,12,22), Email = "ariel.fiengo@gmail.com", CellphoneNumber = 72744409, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = 2, FirstName = "Mauricio", LastName = "Terceros", Birthday = new DateTime(1987,02,7), Email = "mauricio.terceros@gmail.com", CellphoneNumber = 75480016, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = 3, FirstName = "Diego", LastName = "Fiengo", Birthday = new DateTime(1993,10,11), Email = "fiengo.arnez.diego@gmail.com", CellphoneNumber = 71744004, City = "Cochabamba", Country = "Bolivia"},
                new User() { Id = 4, FirstName = "David", LastName = "Carvajal", Birthday = new DateTime(1981,12,16), Email = "d.carvajal@gmail.com", CellphoneNumber = 70726199, City = "Cochabamba", Country = "Bolivia"},
            };
    }

    public List<User> GetAll()
    {
        return _users;
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

    public User Create(User item)
    {
        _users.Add(item);
        return item;
    }

    public User Update(int id, User item)
    {
        User userFound = _users.Find(u => u.Id == id);
        userFound.FirstName = item.FirstName;
        userFound.LastName = item.LastName;
        userFound.Birthday = item.Birthday;
        userFound.Email = item.Email;
        userFound.CellphoneNumber = item.CellphoneNumber;
        userFound.City = item.City;
        userFound.Country = item.Country;
        return userFound;
    }

    public bool Delete(int id)
    {
        User userToDelete = _users.Find(u => u.Id == id);
        return _users.Remove(userToDelete);
    }
}
