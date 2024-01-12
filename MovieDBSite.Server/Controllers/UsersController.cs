using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDBSite.Server.Models;

namespace MovieDBSite.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		//For testing purposes only
		private readonly User _sampleUser = new User { Username = "demo", Password = "password" };

		[HttpPost("login")]
		public ActionResult<string> Login([FromBody] User user)
		{
			if (user.Username == _sampleUser.Username && user.Password == _sampleUser.Password)
			{
				// Successful login
				return Ok("Login successful");
			}

			// Unauthorized
			return Unauthorized("Invalid credentials");
		}
	}
}
