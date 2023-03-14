using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public List<EventShow> EventShows { get; set; }
    }
}
