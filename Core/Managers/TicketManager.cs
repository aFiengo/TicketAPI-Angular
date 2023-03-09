using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Managers
{
    public class TicketManager
    {
        //private EventShowManager _eventManager;
        //private ZoneManager _zoneManager;
        //private UserManager _userManager;

        //private List<Ticket> _ticketList;
        //public TicketManager(EventShowManager eventShowManager, ZoneManager zoneManager, UserManager userManager) 
        //{
        //    _eventManager = eventShowManager;
        //    _zoneManager = zoneManager;
        //    _userManager = userManager;
        //    _ticketList= new List<Ticket>();
        //}
        ///*public Ticket GenerateTicket (EventShow eventShow, User user, Zone zone, int quantity)
        //{
        //    string eventName = eventShow.Name;
        //    string eventCategory = eventShow.Category.Name;
        //    string venueName = eventShow.Location.Name;
        //    string venueCity = eventShow.Location.City;
        //    string venueCountry = eventShow.Location.Country;
        //    DateTime eventDate = eventShow.EventDate;
        //    string zoneName = zone.Name;
        //    double zonePrice = zone.TicketPrice;
        //    string userName = user.FirstName + " " + user.LastName;
        //    string userMail = user.Email;

        //    double totalPrice = 
        //}*/
        //public class TicketRequest
        //{
        //    public int EventId { get; set; }
        //    public int ZoneId { get; set; }
        //    public int Quantity { get; set; }
        //    public int UserId { get; set; }
        //}
        //public class TicketSummary
        //{
        //    public Guid TicketId { get; set; }
        //    public string EventName { get; set; }
        //    public string LocationName { get; set; }
        //    public string LocationCity { get; set; }
        //    public string LocationCountry { get; set; }
        //    public string ZoneName { get; set; }
        //    public double ZoneTicketPrice { get; set; }
        //    public string UserName { get; set; }
        //    public string UserEmail { get; set; }
        //}
        //public List<TicketSummary> GenerateTickets(TicketRequest ticketRequest)
        //{
        //    var tickets = new List<TicketSummary>();

        //    EventShow eventShow = _eventManager.GetEventById(ticketRequest.EventId);
        //    Zone zone = _zoneManager.GetZoneById(ticketRequest.ZoneId);
        //    //User user = _userManager.GetUserById(ticketRequest.UserId);

        //    if (eventShow == null || zone == null || user == null)
        //    {
        //        throw new Exception("Invalid data");
        //    }

        //    for (int i = 0; i < ticketRequest.Quantity; i++)
        //    {
        //        Ticket ticket = new Ticket
        //        {
        //            Id = Guid.NewGuid(),
        //            EventShowInfo = new EventShow
        //            {
        //                Id = eventShow.Id,
        //                Name = eventShow.Name,
        //                Location = new Venue
        //                {
        //                    Name = eventShow.Location.Name,
        //                    City = eventShow.Location.City,
        //                    Country = eventShow.Location.Country,
        //                    SeatedCapacity = eventShow.Location.SeatedCapacity,
        //                    FieldCapacity = eventShow.Location.FieldCapacity,
        //                },
        //                Zones = new List<Zone>
        //                {
        //                    new Zone
        //                    {
        //                        Id = zone.Id,
        //                        Name = zone.Name,
        //                        TicketPrice = zone.TicketPrice
        //                    }
        //                }
        //            },
        //            Quantity = 1,
        //            UserInfo = new User
        //            {
        //                Id = user.Id,
        //                FirstName = user.FirstName,
        //                LastName = user.LastName,
        //                Email = user.Email
        //            },
        //            //ZoneInfo = zone
        //        };
        //        tickets.Add(new TicketSummary
        //        {
        //            TicketId = ticket.Id,
        //            EventName = ticket.EventShowInfo.Name,
        //            LocationName = ticket.EventShowInfo.Location.Name,
        //            LocationCity = ticket.EventShowInfo.Location.City,
        //            LocationCountry = ticket.EventShowInfo.Location.Country,
        //            //ZoneName = ticket.ZoneInfo.Name,
        //            //ZoneTicketPrice = ticket.ZoneInfo.TicketPrice,
        //            UserName = ticket.UserInfo.FirstName + " " + ticket.UserInfo.LastName,
        //            UserEmail = ticket.UserInfo.Email
        //        });
        //        _ticketList.Add(ticket);
        //    }
        //    return tickets;
        //}
        //public List<Ticket> GetAllTickets()
        //{
        //    return _ticketList;
        //}
    }

}
