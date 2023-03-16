
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenser.Data;
using Truextend.TicketDispenser.Core.Managers.Base;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class UserManager : IGenericManager<User>
    {
        private readonly IUnitOfWork _uow;

        public UserManager(IUnitOfWork uow) 
        {
            _uow = uow;
            
        }
        public async Task<IEnumerable<User>> GetAll() 
        {
            return await _uow.UserRepository.GetAllAsync();
        }
        public async Task<User> GetById(int id)
        {
            return await _uow.UserRepository.GetUserById(id);
        }
        public async Task<User> Create(User userToAdd)
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
            return await _uow.UserRepository.CreateAsync(userToAdd);
        }
        public async Task<User> Update(int id, User userToUpdate)
        {
            User userFound = await _uow.UserRepository.GetByIdAsync(id);
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
            return await _uow.UserRepository.UpdateAsync(userToUpdate);
        }
        public async Task<bool> Delete(int id) 
        {
            User userFound = await _uow.UserRepository.GetByIdAsync(id);
            await _uow.UserRepository.DeleteAsync(userFound);
            return await _uow.UserRepository.GetByIdAsync(id) == null;

        }
        
    }
}
