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

			builder.ApplyConfiguration(new MeowsicLabzz.Data.Configurations.Entities.RoleSeed());
			builder.ApplyConfiguration(new MeowsicLabzz.Configurations.Entities.UserSeed());
			builder.ApplyConfiguration(new MeowsicLabzz.Configurations.Entities.UserRoleSeed());
		}
	}
}

