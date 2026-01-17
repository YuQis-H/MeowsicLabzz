using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
	public class SongSeed : IEntityTypeConfiguration<Song>
	{
		public void Configure(EntityTypeBuilder<Song> builder)
		{
			builder.HasData(
				new Song { 
					Id =1, 
					Title = "Happier Than Ever",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song { 
					Id =2, 
					Title = "Bad Guy",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song { 
					Id =3, 
					Title = "MANIAC",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song {
					Id =4, 
					Title = "God's Menu",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song { 
					Id =5, 
					Title = "positions",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song { 
					Id =6, 
					Title = "7 rings",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
			);
		}
	}
}
