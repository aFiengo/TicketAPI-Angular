using AutoMapper;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Mapper;
public class TicketDispenserProfile : Profile
{
	public TicketDispenserProfile()
	{
		CreateMap<Zone, ZoneDTO>().ReverseMap();
	}
}