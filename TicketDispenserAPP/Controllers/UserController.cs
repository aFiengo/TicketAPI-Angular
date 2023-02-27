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
        public IActionResult CreateUser(Guid id, string firstName, string lastName, DateOnly birthday, string email, int cellphoneNumber, string city, string country)
        {
            User userToCreate = _userManager.AddUser(id, firstName, lastName, birthday, email, cellphoneNumber, city, country);
            return Ok(userToCreate);
        }
        [HttpPut]
        [Route ("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] User selectedUser) 
        {
            User userToUpdate = _userManager.UpdateUser(id, selectedUser);
            return Ok(userToUpdate);
        }
        [HttpDelete]
        [Route ("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id) 
        {
            User userToDelete = _userManager.DeleteUser(id);
            return Ok(userToDelete);
        }
    }
}
