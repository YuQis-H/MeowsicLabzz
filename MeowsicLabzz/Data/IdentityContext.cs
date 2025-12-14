using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeowsicLabzz.Data
{
	public class IdentityContext : IdentityDbContext<MeowsicLabzzUser>
	{
		public IdentityContext(DbContextOptions<IdentityContext> options)
			: base(options) { }
	}
}
