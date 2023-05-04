using Microsoft.AspNetCore.Mvc;
using Vendor.Interface.Model.Response;
using Vendor.Services.Login;
using Vendor.Services.Model.Request;


namespace Vendor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService _login;
        public LoginController(ILogger<LoginController> logger, ILoginService login)
        {
            _logger = logger;
            _login = login;
        }

        [HttpPost("login")]
        public Response AuthenticateUser(LoginRequest credential)
        {
            Response res = _login.AuthenticateUser(credential);
            if (res.IsSuccess == 1)
                return res.Result;
            else
                return res.Result.Error;
            
        }
    }
}


