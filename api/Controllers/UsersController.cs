using api.Contracts;
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

        public UsersController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }


        [HttpPost]
        public IActionResult RegisterUser([FromBody] RegisterUserDto dto)
        {

            var (username, password, birthday) = dto;
            var user = new User(username, password, birthday);
            _userRepo.Create(user);

            return CreatedAtRoute(nameof(Find), new {id = user.Id}, user);
            
        }
        [HttpGet("{id}", Name ="Find")]
        public ActionResult<UserDto> Find(Guid id)
       {
            var user = _userRepo.Find(id);
            var userDto = new UserDto(user.Username, user.Birthday);
            return userDto;

        }
    }
}
