using MeowsicLabzz.Components.Account.Pages;
using MeowsicLabzz.Components.Domain;
using MeowsicLabzz.Configurations.Entities;
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

		// 🎶 Music domain entities
		public DbSet<Mood> Moods { get; set; } = default!;
		public DbSet<Genre> Genres { get; set; } = default!;
		public DbSet<Artist> Artists { get; set; } = default!;
		public DbSet<Song> Songs { get; set; } = default!;
		public DbSet<Album> Albums { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.MusicDiscovery> MusicDiscovery { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.Friends> Friends { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.MyPlaylist> MyPlaylist { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.User> User { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// Identity seeding
			builder.ApplyConfiguration(new RoleSeed());
			builder.ApplyConfiguration(new UserSeed());
			builder.ApplyConfiguration(new UserRoleSeed());

			// Optional: seeding for music entities
			builder.ApplyConfiguration(new MoodSeed());
			builder.ApplyConfiguration(new GenreSeed());
			builder.ApplyConfiguration(new ArtistSeed());
			builder.ApplyConfiguration(new AlbumSeed());
			builder.ApplyConfiguration(new SongSeed());
			builder.ApplyConfiguration(new MusicDiscoverySeed());
			builder.ApplyConfiguration(new FriendsSeed());
			builder.ApplyConfiguration(new MyPlaylistSeed());
			
        }
	    
	}
}
