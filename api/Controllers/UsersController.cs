using api.Contracts;
using app_services;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly IUserService _userService;

        public UsersController(IUserRepository userRepo, IUserService userService)
        {
            _userRepo = userRepo;
            _userService = userService;
        }


        [HttpPost]
        public IActionResult RegisterUser([FromBody] RegisterUserDto dto)
        {
            var (username, password, birthday) = dto;
            var command = new RegisterUserCommand(username, password, birthday);
            var userId = _userService.Register(command);
            
            return CreatedAtRoute(nameof(Find), new { id = userId }, null);

        }
        [HttpGet("{id}", Name = "Find")]
        public ActionResult<UserDto> Find(Guid id)
        {

            var user = _userRepo.Find(id);
            var userDto = new UserDto(user.Username, user.Birthday);
            return userDto;

        }
    }
}
