using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Core.Models
{
    public class Zone
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float CapPorcentage { get; set; }
        public int Capacity { get; set; }
        public double TicketPrice { get; set; }
    }
}
