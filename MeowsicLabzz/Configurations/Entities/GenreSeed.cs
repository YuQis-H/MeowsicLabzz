using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class GenreSeed : IEntityTypeConfiguration<Genre>
	{
		public void Configure(EntityTypeBuilder<Genre> builder)
		{
			builder.HasData(
				new Genre { 
					Id =1, 
					Name = "Pop",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Genre { 
					Id =2,
					Name = "Rock",
					CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Genre { 
					Id =3, 
					Name = "R&B",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Genre {
					Id =4,
					Name = "Classical",
					CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
				}
			);
		}
	}
}
