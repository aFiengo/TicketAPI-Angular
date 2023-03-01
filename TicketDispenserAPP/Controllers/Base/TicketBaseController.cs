using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers.Base;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers.Base;
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
    [Route("{id}")]
    public IActionResult GetItemByID([FromRoute] int id)
    {
        return Ok(_classManager.GetById(id));
    }

    [HttpPost]
    [Route("")]
    public IActionResult AddItem([FromBody] T item)
    {
        return Ok(_classManager.Create(item));
    }

    [HttpPut("{id}")]
    public IActionResult UpdateById([FromRoute] int id, [FromBody] T item)
    {
        return Ok(_classManager.Update(id, item));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        return Ok(_classManager.Delete(id));
    }


}