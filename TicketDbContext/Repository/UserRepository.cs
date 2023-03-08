using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data.Repository.Interfaces;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Core.Services;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<User> GetUserById(int id)
        {
            IEnumerable<User> users = await GetAllAsync(u => u.Id == id);
            return users.Any() ? users.First() : null;
        }
        
    }
}
