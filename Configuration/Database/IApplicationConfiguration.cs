using Truextend.TicketDispenserAPI.Configuration.Models;

namespace Truextend.TicketDispenserAPI.Configuration.Database;
public interface IApplicationConfiguration
{
        DatabaseConnectionStrings GetDatabaseConnectionString();
}
