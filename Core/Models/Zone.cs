namespace Truextend.TicketDispenser.Core.Models;
public class Zone
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public double TicketPrice { get; set; }
    public float Percentage { get; set; }
    public Zone()
    {
        Percentage = ((float)new Random().NextDouble());
    }
}