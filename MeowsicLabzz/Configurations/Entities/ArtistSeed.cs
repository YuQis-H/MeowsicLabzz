using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class ArtistSeed : IEntityTypeConfiguration<Artist>
	{
		public void Configure(EntityTypeBuilder<Artist> builder)
		{
			builder.HasData(
				new Artist { Id =1, Name = "Billie Eilish" },
				new Artist { Id =2, Name = "Stray Kids" },
				new Artist { Id =3, Name = "Ariana Grande" }
			);
		}
	}
}
