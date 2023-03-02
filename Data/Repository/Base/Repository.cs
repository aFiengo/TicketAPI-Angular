using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

using Truextend.TicketDispenser.Data.Exceptions;
using Truextend.TicketDispenser.Data.Models.Base;
using Truextend.TicketDispenser.Data.Repository.Interfaces;
using Truextend.TicketDispenserAPI.Data;

namespace Truextend.TicketDispenser.Data.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly TicketDispenserDBContext dbContext;

        public Repository(TicketDispenserDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<T> CreateAsync(T entity)
        {
            try
            {
                dbContext.Set<T>().Add(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            }
            catch(Exception e)
            {
                throw new DatabaseException("ERROR: "+e.InnerException.Message);
            }

            
        }

        public async Task<T> DeleteAsync(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            List<T> values = await dbContext.Set<T>().ToListAsync();
            return values;
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, Boolean>> predicate)
        {
            return await dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T value = await dbContext.Set<T>().FindAsync(id);
            return value;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public bool ExistsByPredicate(Expression<Func<T, Boolean>> predicate)
        {
            return dbContext.Set<T>().Where(predicate).Any();
        }
    }
}
