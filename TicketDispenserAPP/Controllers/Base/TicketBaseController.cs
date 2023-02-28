using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers.Base;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base
{
    public class TicketBaseController<T> : ControllerBase where T : class
    {
        private readonly IGenericManager<T> _classManager;

        public TicketBaseController(IGenericManager<T> classManager)
        {
            _classManager = classManager;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            return Ok(_classManager.GetAll());
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetItemByID([FromRoute] int Id)
        {
            return Ok(_classManager.GetById(Id));
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddItem([FromBody] T item)
        {
            return Ok(_classManager.Create(item));
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateById([FromRoute] int id, [FromBody] T item)
        {
            return Ok(_classManager.Update(id, item));
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] int Id)
        {
            return Ok( _classManager.Delete(Id));
        }


    }
}