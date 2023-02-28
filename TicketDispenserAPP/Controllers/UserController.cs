using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : TicketBaseController<User>
    {
        private readonly UserManager _userManager;
        public UserController(UserManager userManager) : base(userManager)
        {
            _userManager = userManager;
        }
    }
}
