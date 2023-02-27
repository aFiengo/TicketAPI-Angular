using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Core.Models
{
    public class EventShow
    {
        public Guid Id { get; set; }
        public CategoryModel Category { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public VenueModel Location { get; set; }
    }
}
