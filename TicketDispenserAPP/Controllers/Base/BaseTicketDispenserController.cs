using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers.Base;
using Truextend.TicketDispenser.TicketDispenserAPI.Middleware;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base
{
    [ApiController]
    public class BaseTicketDispenserController<T> : ControllerBase where T : class
    {
        private readonly IGenericManager<T> _classManager;
        public BaseTicketDispenserController(IGenericManager<T> ClassManager)
        {
            _classManager = ClassManager;
        }
        [HttpGet]
        public virtual async Task<IActionResult> GetAllItems()
        {
            return Ok(new MiddlewareResponse<IEnumerable<T>>(await _classManager.GetAll()));
        }
    }
}
