using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Trips_Core.IServices;
using Project_Trips_Core.ModelDto;
using Project_Trips_Data.Models;

namespace Project_Trips_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
      
        private readonly IUserService _usersService;
   
        public UsersController(IUserService userService)
        {
            _usersService = userService;
        }

        [HttpGet]
        [Route(nameof(GetAll))]
        public async Task<List<UserDto>> GetAll()
        {
            return await _usersService.GetAllUser();
        }

        [HttpGet]
        [Route(nameof(Login))]
        public async Task<UserDto> Login(string userName, string password)
        {
            return await _usersService.Login(userName, password);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route(nameof(AddUser))]

        public async Task<IActionResult> AddUser(UserDto q)
        {
            bool isOK = await _usersService.AddUser(q);
            return Ok(isOK);
        }


    }
}
