using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truextend.TicketDispenser.Core.Managers;
using Truextend.TicketDispenser.Core.Models;
using Truextend.TicketDispenser.Data.Models;

namespace Truextend.TicketDispenser.TicketDispenserAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager _userManager;
        private readonly IMapper _mapper;
        public UserController(UserManager userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> GetUsers() 
        {
            IEnumerable<User> users = await _userManager.GetAll();
            IEnumerable<UserDTO> usersDTOs = _mapper.Map<IEnumerable<UserDTO>>(users);
            return Ok(usersDTOs);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetUserById(int id)
        {
            User user = await _userManager.GetById(id);
            UserDTO userDTO = _mapper.Map<UserDTO>(user);
            return Ok(userDTO);
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
