using JwtAuthenticationApi.Models.ViewModels;
using JwtAuthenticationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthenticationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationManager _authManager;

        public LoginController(IAuthenticationManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost("AuthenticateUser")]
        public IActionResult AuthenticateUser([FromBody] LoginDetails loginDetails)
        {
            var token = _authManager.Authenticate(loginDetails.Username, loginDetails.Password);
            if(token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }

    }
}
