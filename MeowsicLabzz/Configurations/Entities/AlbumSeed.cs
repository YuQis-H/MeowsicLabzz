using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class AlbumSeed : IEntityTypeConfiguration<Album>
	{
		public void Configure(EntityTypeBuilder<Album> builder)
		{
			var now = DateTime.Now.ToString("O");
			builder.HasData(
				new Album { Id =1, Title = "Happier Than Ever", ArtistId =1, GenreId =1,
					CreatedAt = now,
					UpdatedAt = now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Album { Id =2, Title = "ODDINARY", ArtistId =2, GenreId =1,
					CreatedAt = now,
					UpdatedAt = now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Album { Id =3, Title = "Positions", ArtistId =3, GenreId =3,
					CreatedAt = now,
					UpdatedAt = now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				// Billie Eilish album
				new Album { Id =4, Title = "When We All Fall Asleep, Where Do We Go?", ArtistId =1, GenreId =1,
					CreatedAt = now,
					UpdatedAt = now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				// Stray Kids - Go Live album (correct album for God's Menu)
				new Album { Id =5, Title = "Go Live", ArtistId =2, GenreId =1,
					CreatedAt = now,
					UpdatedAt = now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}
