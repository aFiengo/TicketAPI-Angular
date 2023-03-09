using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Core.Services;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<IEnumerable<Category>> GetCategoryById(int id)
        {
            IEnumerable<Category> categories = await GetAllAsync(z => z.Id == id);
            return categories;
        }
    }
}
