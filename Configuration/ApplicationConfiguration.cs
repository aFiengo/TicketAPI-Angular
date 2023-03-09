using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.TicketDispenser.Configuration.Models;

namespace Truextend.TicketDispenser.Configuration.Models
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        private readonly IConfiguration _configuration;
        public ApplicationConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DatabaseConnectionStrings GetDatabaseConnectionString()
        {
            return new DatabaseConnectionStrings()
            {
                DATABASE = _configuration.GetSection("ConnectionStrings").GetSection("TicketConnection").Value
            };
        }
    }
}
