using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.TicketDispenser.Configuration.Models
{
    public interface IApplicationConfiguration
    {
        DatabaseConnectionStrings GetDatabaseConnectionString();
    }
}
