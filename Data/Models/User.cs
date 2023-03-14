using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int CellphoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
