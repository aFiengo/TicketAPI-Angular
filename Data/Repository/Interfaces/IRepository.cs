using System.Linq.Expressions;

using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Repository.Interfaces;
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        bool ExistsByPredicate(Expression<Func<T, Boolean>> predicate);
    }