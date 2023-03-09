using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager _userManager;
        public UserController(UserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<ActionResult> GetUsers() 
        {
            IEnumerable<User> users = await _userManager.GetAll();
            return Ok(users);
        }
        [HttpPost]
        public async Task<ActionResult> CreateUser(User userToAdd)
        {
            User createdUser = await _userManager.Create(userToAdd);
            return Ok(createdUser);
        }
        [HttpPut]
        [Route ("{id}")]
        public async Task<ActionResult> UpdateUser([FromRoute] int id, [FromBody] User selectedUser) 
        {
            User userToUpdate = await _userManager.Update(id, selectedUser);
            return Ok(userToUpdate);
        }
        [HttpDelete]
        [Route ("{id}")]
        public async Task<ActionResult> DeleteUser([FromRoute] int id) 
        {
            bool userToDelete = await _userManager.Delete(id);
            return Ok(userToDelete);
        }
    }
}
