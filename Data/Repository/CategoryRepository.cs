using Truextend.TicketDispenser.Data.Models;
using Truextend.TicketDispenser.Data.Repository.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;

namespace Truextend.TicketDispenser.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(TicketDbContext ticketDbContext) : base(ticketDbContext) { }
        public async Task<Category> GetCategoryById(int id)
        {
            IEnumerable<Category> categories = await GetAllAsync(c => c.Id == id);
            return categories.Any() ? categories.First() : null;
        }
    }
}
