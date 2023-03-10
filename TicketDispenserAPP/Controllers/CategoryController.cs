
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data.Models;

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
        public async Task<ActionResult> GetCategories()
        {
            IEnumerable<Category> categories = await _categoryManager.GetAll();
            return Ok(categories);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetCategoryById(int id)
        {
            Category category = await _categoryManager.GetById(id);
            return Ok(category);
        }
        [HttpPost]
        public async Task<ActionResult> CreateCategory(Category categoryToAdd)
        {
            Category createdCategory = await _categoryManager.Create(categoryToAdd);
            return Ok(createdCategory);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> UpdateCategory([FromRoute] int id, [FromBody] Category selectedCategory)
        {
            Category categoryToUpdate = await _categoryManager.Update(id, selectedCategory);
            return Ok(categoryToUpdate);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteCategory([FromRoute] int id)
        {
            bool categoryToDelete = await _categoryManager.Delete(id);
            return Ok(categoryToDelete);
        }
    }
}
