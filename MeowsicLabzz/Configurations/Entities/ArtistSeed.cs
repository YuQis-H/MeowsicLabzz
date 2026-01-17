using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class ArtistSeed : IEntityTypeConfiguration<Artist>
	{
		public void Configure(EntityTypeBuilder<Artist> builder)
		{   
			var now = DateTime.Now.ToString("o");
			builder.HasData(
				new Artist { Id =1, Name = "Billie Eilish",
					CreatedAt = now,
                    UpdatedAt = now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Artist { Id =2, Name = "Stray Kids",
                    CreatedAt = now,
                    UpdatedAt = now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Artist { Id =3, Name = "Ariana Grande",
                    CreatedAt = now,
                    UpdatedAt = now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
			);
		}
	}
}
