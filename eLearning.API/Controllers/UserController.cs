using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLearning.API.DTOs.User;
using eLearning.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eLearning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginRequest request) {

            var loginResult = _userService.LoginUserAsync(request);

            return Ok(loginResult);
        }


        [HttpPost("Register")]
        public IActionResult Register(RegisterRequest request)
        {
            var loginResult = _userService.RegisterUserAsync(request);

            return Ok(loginResult);
        }
    }
}
