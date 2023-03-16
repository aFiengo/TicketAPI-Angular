namespace Truextend.TicketDispenser.Core.Models
{
    public class TicketDTO
    {
        public int Number { get; set; }
        public string EventName { get; set; }
        public string ZoneName { get; set; }
        public DateTime Date { get; set;}
        public double Price {get; set;}

    }
}