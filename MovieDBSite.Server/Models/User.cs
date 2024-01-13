namespace MovieDBSite.Server.Models
{
	public class User
	{
		//Might change to email or have both username and email
		public required string Username { get; set; }

		//Need to figure out if I need to encrypt it here, later, or if I can do that in the front-end
		public required string Password { get; set; }

		//Might make required
		public string? Name { get; set; }
		public string? Bio { get; set; }
	}
}
