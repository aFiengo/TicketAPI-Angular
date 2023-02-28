namespace Truextend.TicketDispenser.Core.Models
{
    public class EventShow
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public Venue Venue { get; set; }
    }
}
