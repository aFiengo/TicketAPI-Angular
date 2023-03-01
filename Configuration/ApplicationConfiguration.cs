using Microsoft.Extensions.Configuration;
using Truextend.TicketDispenserAPI.Configuration.Database;
using Truextend.TicketDispenserAPI.Configuration.Models;

namespace Truextend.TicketDispenserAPI.Configuration;

    public class ApplicationConfiguration: IApplicationConfiguration
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
                DATABASE = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value
            };
        }
    }

