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
					ArtistType = "Soloist",
					Gender = "Female",
					CreatedAt = now,
                    UpdatedAt = now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Artist { Id =2, Name = "Stray Kids",
					ArtistType = "Group",
					Gender = "Mixed",
                    CreatedAt = now,
                    UpdatedAt = now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Artist { Id =3, Name = "Ariana Grande",
					ArtistType = "Soloist",
					Gender = "Female",
                    CreatedAt = now,
                    UpdatedAt = now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
			);
		}
	}
}
