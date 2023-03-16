using Mysqlx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models.Validation;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Models
{
    public class TicketDTO 
    {
        public Guid Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string VenueName { get; set; }
        public string VenueLocation { get; set; }
        public string ZoneName { get; set; }
        public double TicketPrice { get; set; }

        
    }

}
