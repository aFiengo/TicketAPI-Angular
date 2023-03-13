using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models
{
    public class Zone : Entity
    {
        public string Name { get; set; }
        public float CapPercentage { get; set; }
        public int Capacity { get; set; }//(Venue venue) => (int)(venue.TotalCapacity * CapPorcentage);
        public double TicketPrice { get; set; }
        public List<EventZone> EventZones { get; set; }
    }
}
