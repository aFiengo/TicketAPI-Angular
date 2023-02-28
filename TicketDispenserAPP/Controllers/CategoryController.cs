
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryManager _categoryManager;
        public CategoryController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        [HttpGet]
        public IActionResult GetCategories()
        {
            List<Category> categorys = _categoryManager.GetCategories();
            return Ok(categorys);
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category categoryToAdd)
        {
            this._categoryManager.AddCategory(categoryToAdd);
            return Ok(categoryToAdd);
        }

        [HttpPut]
        [Route("{Id}")]
        public IActionResult UpdateCategory([FromRoute] int Id, [FromBody] Category categoryToUpdate)
        {
            return Ok(this._categoryManager.UpdateCategory(Id, categoryToUpdate));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteCategory([FromRoute] int id)
        {
            Category categoryToDelete = _categoryManager.DeleteCategory(id);
            return Ok(categoryToDelete);
        }
    }
}
