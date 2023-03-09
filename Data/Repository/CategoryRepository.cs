using Truextend.TicketDispenser.Data.Models;
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
