using Truextend.TicketDispenser.Data.Models.Base;

namespace Truextend.TicketDispenser.Data.Models;
public class Zone : Entity
{
    public string Name { get; set; }
    public double TicketPrice { get; set; }
    public float Percentage { get; set; }
    public int Capacity { get; set; }
    public Zone()
    {
        Percentage = ((float)new Random().NextDouble());
    }
}