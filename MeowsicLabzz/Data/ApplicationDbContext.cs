using MeowsicLabzz.Data.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeowsicLabzz.Data
{
	public class ApplicationDbContext : IdentityDbContext<MeowsicLabzzUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
        }

        protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// Apply your role seed configuration
			builder.ApplyConfiguration(new RoleSeed());
		}
	}
}

