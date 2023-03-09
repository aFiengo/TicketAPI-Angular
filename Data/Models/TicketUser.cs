using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{
    public class TicketUser : Entity
    {
        public Guid TicketId { get; set; }
        public int UserId { get; set; }
    }
}
