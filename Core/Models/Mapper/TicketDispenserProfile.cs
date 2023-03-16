using AutoMapper;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.Core.Models.Mapper
{
    public class TicketDispenserProfile : Profile 
    {
        public TicketDispenserProfile() 
        {
            CreateMap<Ticket, TicketDTO>()
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.EventShow.EventDate))
                .ForMember(dest => dest.EventName, opt => opt.MapFrom(src => src.EventShow.Name))
                .ForMember(dest => dest.ZoneName, opt => opt.MapFrom(src => src.EventShow.EventZones.Where(ez => ez.ZoneId == src.ZoneId).Select(ez => ez.Zone.Name)))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.EventShow.EventZones.Where(ez => ez.ZoneId == src.ZoneId).Select(ez => ez.Zone.TicketPrice).FirstOrDefault()));
        }
        
    }
}