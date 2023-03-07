
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models.Base;

namespace Truextend.TicketDispenser.Core.Models
{
    public class EventShow : Entity
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public Venue Location { get; set; }
        public List<Zone> Zones { get; set; }
    }
}
