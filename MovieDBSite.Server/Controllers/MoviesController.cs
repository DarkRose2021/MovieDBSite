using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieDBSite.Server.Services;

namespace MovieDBSite.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		private readonly MovieDbService _movieDbService;

		public MoviesController(MovieDbService movieDbService)
		{
			_movieDbService = movieDbService;
		}

		[HttpGet("movie/changes")]
		public async Task<IActionResult> GetMovieChanges(int page = 1)
		{
			string movieChanges = await _movieDbService.GetMovieChanges(page);

			if (movieChanges != null)
			{
				return Ok(movieChanges);
			}

			return NotFound();
		}
	}
}
