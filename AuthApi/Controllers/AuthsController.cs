using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthsController : Controller
    {

        IConfiguration _configuration;
        public AuthsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Login(string userName, string password)
        {
            TokenHandler._configuration = _configuration;
            return Ok(userName == "Profen" && password == "12345" ? TokenHandler.CreateAccessToken() : new UnauthorizedResult());
        }
    }
}

