using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReverseMacros.API.Controllers.Auth
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login() { 
            throw new NotImplementedException();
        }

        [HttpPost("google")]
        public async Task<IActionResult> LoginGoogle()
        {
            throw new NotImplementedException();
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout() {
            throw new NotImplementedException();
        }

    }
}
