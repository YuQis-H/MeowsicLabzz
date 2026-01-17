using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class MoodSeed : IEntityTypeConfiguration<Mood>
	{
		public void Configure(EntityTypeBuilder<Mood> builder)
		{
			builder.HasData(
				new Mood { 
					Id =1, 
					Name = "Happy",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Mood { 
					Id =2,
					Name = "Sad",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                 },
				new Mood { Id =3,
					Name = "Energetic",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Mood {
					Id =4,
					Name = "Chill",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
			);
		}
	}
}
