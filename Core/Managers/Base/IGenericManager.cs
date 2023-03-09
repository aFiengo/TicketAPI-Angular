using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Core.Managers.Base
{
    public interface IGenericManager<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T item);
        Task<T> Update(int id, T item);
        Task<bool> Delete(int itemId);
    }
}
