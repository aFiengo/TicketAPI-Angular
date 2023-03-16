using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Core.Models
{
    public class EventShowDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VenueName { get; set; }
        public string VenueLocation { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<ZoneDTO> Zones { get; set; }
    }
}
