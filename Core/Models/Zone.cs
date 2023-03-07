using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models.Base;

namespace Truextend.TicketDispenser.Core.Models
{
    public class Zone : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float CapPorcentage { get; set; }
        public int Capacity (Venue venue) => (int)(venue.TotalCapacity * CapPorcentage);
        public double TicketPrice { get; set; }
    }
}
