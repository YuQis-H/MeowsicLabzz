using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class AlbumSeed : IEntityTypeConfiguration<Album>
	{
		public void Configure(EntityTypeBuilder<Album> builder)
		{
			builder.HasData(
				new Album { Id =1, Title = "Happier Than Ever", ArtistId =1 },
				new Album { Id =2, Title = "ODDINARY", ArtistId =2 },
				new Album { Id =3, Title = "Positions", ArtistId =3 }
			);
		}
	}
}
