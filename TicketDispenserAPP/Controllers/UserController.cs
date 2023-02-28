using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;

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
        public IActionResult GetUsers() 
        {
            List<User> users = _userManager.GetUsers();
            return Ok(users);
        }
        [HttpPost]
        public IActionResult CreateUser(User userToAdd)
        {
            this._userManager.AddUser(userToAdd);
            return Ok(userToAdd);
        }
        [HttpPut]
        [Route ("{id}")]
        public IActionResult UpdateUser([FromRoute] int id, [FromBody] User selectedUser) 
        {
            User userToUpdate = _userManager.UpdateUser(id, selectedUser);
            return Ok(userToUpdate);
        }
        [HttpDelete]
        [Route ("{id}")]
        public IActionResult DeleteUser([FromRoute] int id) 
        {
            User userToDelete = _userManager.DeleteUser(id);
            return Ok(userToDelete);
        }
    }
}
