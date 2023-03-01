using AutoMapper;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Core.Models.DTOs;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Mapper;
public class TicketDispenserProfile : Profile
{
	public TicketDispenserProfile()
	{
		CreateMap<Zone, ZoneDTO>().ReverseMap();
		// Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
	}
}