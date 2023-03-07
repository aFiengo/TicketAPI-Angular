using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Core.Models.Base;

namespace Truextend.TicketDispenser.Core.Models
{
    public class Category : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
