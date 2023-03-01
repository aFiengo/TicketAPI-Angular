// using Truextend.TicketDispenser.Core.Managers.Base;
// using Truextend.TicketDispenser.Core.Models;

// namespace Truextend.TicketDispenser.Core.Managers;
// public class TicketManager : IGenericManager<Ticket>
// {
//     private List<Ticket> _ticketList;
//     public TicketManager()
//     {
//         _ticketList = new List<Ticket>();
//     }

//     public Ticket Create(Ticket item)
//     {
//         _ticketList.Add(item);
//         return item;
//     }

//     public bool Delete(int id)
//     {
//         Ticket ticketToDelete = _ticketList.Find(t => t.Id == id);
//         return _ticketList.Remove(ticketToDelete);
//     }

//     public List<Ticket> GetAll()
//     {
//         return _ticketList;
//     }

//     public Ticket GetById(int id)
//     {
//         return _ticketList.Find(t => t.Id == id);
//     }

//     public Ticket Update(int id, Ticket item)
//     {
//         throw new NotImplementedException();
//     }
// }
