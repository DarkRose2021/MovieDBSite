using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieDBSite.Server.Services
{
	public class MovieDbService
	{
		private readonly HttpClient _httpClient;
		private readonly string _apiKey = "It's-a-secret"; // Replace with your actual API key

		public MovieDbService(HttpClient httpClient)
		{
			_httpClient = httpClient;
			_httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
		}

		public async Task<string> GetMovieChanges(int page = 1)
		{
			string endpoint = $"movie/changes?page={page}&api_key={_apiKey}";
			HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadAsStringAsync();
			}

			return null; // Handle errors accordingly
		}
	}
}
