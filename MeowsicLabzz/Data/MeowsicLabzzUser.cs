using Microsoft.AspNetCore.Identity;

namespace MeowsicLabzz.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class MeowsicLabzzUser : IdentityUser
    {
		public string? FavoriteGenre { get; set; }
		public string? DisplayName { get; set; }

		public string? FirstName { get; set; }
		public string? LastName { get; set; }
	}
}
