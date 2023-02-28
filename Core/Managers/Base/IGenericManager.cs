namespace Truextend.TicketDispenser.Core.Managers.Base
{
    public interface IGenericManager<T> where T: class
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T item);
        T Update(int id, T item);
        bool Delete(int id);
    }
}
