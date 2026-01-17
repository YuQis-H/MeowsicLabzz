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
				new Genre { Id =1, Name = "Pop",},
				new Genre { Id =2, Name = "Rock" },
				new Genre { Id =3, Name = "Jazz" },
				new Genre { Id =4, Name = "Classical" }
			);
		}
	}
}
