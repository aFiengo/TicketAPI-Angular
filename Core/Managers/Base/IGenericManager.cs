namespace Truextend.TicketDispenser.Core.Managers.Base;
public interface IGenericManager<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> Create(T item);
    Task<T> Update(int id, T item);
    bool Delete(int id);
}
