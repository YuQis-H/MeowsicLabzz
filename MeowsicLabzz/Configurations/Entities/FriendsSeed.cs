using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
    public class FriendsSeed : IEntityTypeConfiguration<Friends>
    {
        public void Configure(EntityTypeBuilder<Friends> builder)
        {
            builder.HasData(
                new Friends { Id = 1, Name = "Chee Peng"},
                new Friends { Id = 2, Name = "Ding Tan" }
            );
        }
    }
}
