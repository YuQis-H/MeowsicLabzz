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
					ArtistId =1, 
					AlbumId =1, 
					GenreId =1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song { 
					Id =2, 
					Title = "Bad Guy", 
					ArtistId =1, 
					AlbumId =4, 
					GenreId =1 ,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song {
					Id =3, 
                    Title = "MANIAC", 
                    ArtistId =2, 
                    AlbumId =2, 
                    GenreId =1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }, 
				new Song { 
					Id =4,
                    Title = "God's Menu", 
                    ArtistId =2, 
                    AlbumId =5, 
                    GenreId =2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }, 
				new Song { 
					Id =5, 
                    Title = "positions", 
                    ArtistId =3, 
                    AlbumId =3, 
                    GenreId =3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Song { 
					Id =6, 
                    Title = "7 rings", 
                    ArtistId =3, 
                    AlbumId =3, 
                    GenreId =1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
			);
		}
	}
}
