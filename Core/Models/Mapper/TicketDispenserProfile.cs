using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Models.Mapper
{
    public class TicketDispenserProfile : Profile
    {
        public TicketDispenserProfile() 
        {
            //this.CreateMap<Guid, int>().ConvertUsing(guid => (int)guid.GetHashCode());
            this.CreateMap<Ticket, TicketDTO>()
                .ForMember(dest => dest.EventName, opt => opt.MapFrom(src => src.EventShow.Name))
                .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.EventShow.EventDate))
                .ForMember(dest => dest.VenueName, opt => opt.MapFrom(src => src.EventShow.Venue.Name))
                .ForMember(dest => dest.VenueLocation, opt => opt.MapFrom(src => src.EventShow.Venue.City + ", " + src.EventShow.Venue.Country))
                .ForMember(dest => dest.ZoneName, opt => opt.MapFrom(src => src.Zone.Name))
                .ForMember(dest => dest.TicketPrice, opt => opt.MapFrom(src => src.Zone.TicketPrice))
                .ReverseMap();
            this.CreateMap<Category, CategoryDTO>()
                .ReverseMap();
            this.CreateMap<EventShow, EventShowDTO>()
                .ForMember(dest => dest.VenueLocation, opt => opt.MapFrom(src => src.Venue.City + ", " + src.Venue.Country))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.EventDate))
                .ForMember(dest => dest.Zones, opt => opt.MapFrom(src => src.EventZones.Select(ez => ez.Zone)))
                .ReverseMap();
            this.CreateMap<User, UserDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => CalculateAge(src.Birthday)))
                .ReverseMap();
            this.CreateMap<Venue, VenueDTO>()
                .ReverseMap();
            this.CreateMap<Zone, ZoneDTO>()
                .ReverseMap();

        }
        public int CalculateAge(DateTime birthdate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthdate.Year;
            if (now.Month < birthdate.Month || (now.Month == birthdate.Month && now.Day < birthdate.Day))
            {
                age--;
            }
            return age;
        }
    }
}
