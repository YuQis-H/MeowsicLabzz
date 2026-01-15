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
				new Mood { Id =1, Name = "Happy" },
				new Mood { Id =2, Name = "Sad" },
				new Mood { Id =3, Name = "Energetic" },
				new Mood { Id =4, Name = "Chill" }
			);
		}
	}
}
