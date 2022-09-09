using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticationAPI.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IJWTRepository _jWTManager;

		public UsersController(IJWTRepository jWTManager)
		{
		_jWTManager = jWTManager;
		}

		[HttpGet]
		public List<string> Get()
		{
			var users = new List<string>
		{
			"PROFEN PROFEN",
			
		};

			return users;
		}

		[AllowAnonymous]
		[HttpPost]
		[Route("authenticate")]
		public IActionResult Authenticate(User usersdata)
		{
			var token = _jWTManager.Authenticate(usersdata);

			if(token == null)
			{
				return Unauthorized();
			}

			return Ok(token);
		}
	}
}


	