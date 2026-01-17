using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class ArtistSeed : IEntityTypeConfiguration<Artist>
	{
		public void Configure(EntityTypeBuilder<Artist> builder)
		{   
<<<<<<< HEAD
<<<<<<< HEAD
			builder.HasData(
				new Artist { Id =1, Name = "Billie Eilish",
					CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
=======
			var now = DateTime.Now.ToString("o");
			builder.HasData(
				new Artist { Id =1, Name = "Billie Eilish",
=======
			var now = DateTime.Now.ToString("o");
			builder.HasData(
				new Artist { Id =1, Name = "Billie Eilish",
>>>>>>> ca9159786092059d25642f95297f4b8c6c4fd137
					ArtistType = "Soloist",
					Gender = "Female",
					CreatedAt = now,
                    UpdatedAt = now,
>>>>>>> ca9159786092059d25642f95297f4b8c6c4fd137
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Artist { Id =2, Name = "Stray Kids",
<<<<<<< HEAD
<<<<<<< HEAD
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
=======
=======
>>>>>>> ca9159786092059d25642f95297f4b8c6c4fd137
					ArtistType = "Group",
					Gender = "Mixed",
                    CreatedAt = now,
                    UpdatedAt = now,
>>>>>>> ca9159786092059d25642f95297f4b8c6c4fd137
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Artist { Id =3, Name = "Ariana Grande",
<<<<<<< HEAD
<<<<<<< HEAD
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
=======
=======
>>>>>>> ca9159786092059d25642f95297f4b8c6c4fd137
					ArtistType = "Soloist",
					Gender = "Female",
                    CreatedAt = now,
                    UpdatedAt = now,
>>>>>>> ca9159786092059d25642f95297f4b8c6c4fd137
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
			);
		}
	}
}
