using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Core.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int SeatedCapacity { get; set; }
        public int FieldCapacity { get; set; }
        public int TotalCapacity => SeatedCapacity + FieldCapacity;
    }
}

//CALCULATED FIELDS