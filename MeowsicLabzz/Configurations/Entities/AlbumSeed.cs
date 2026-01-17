using System;
using MeowsicLabzz.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeowsicLabzz.Configurations.Entities
{
	public class AlbumSeed : IEntityTypeConfiguration<Album>
	{
		public void Configure(EntityTypeBuilder<Album> builder)
		{
			
			builder.HasData(
				new Album { Id =1, Title = "Happier Than Ever", ArtistId =1, GenreId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Album { Id =2, Title = "ODDINARY", ArtistId =2, GenreId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
				new Album { Id =3, Title = "Positions", ArtistId =3, GenreId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
			);
		}
	}
}
