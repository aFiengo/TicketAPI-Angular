using System.ComponentModel.DataAnnotations;

namespace Truextend.TicketDispenser.Core.Models;
public class ZoneDTO
{
    public int id { get; set; }
    public string Name { get; set; }
    public int TicketPrice { get; set; }
}