using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
    public class MusicDiscoverySeed : IEntityTypeConfiguration<MusicDiscovery>
    {
        public void Configure(EntityTypeBuilder<MusicDiscovery> builder)
        {
            builder.HasData(
                new MusicDiscovery { Id = 1 },
                new MusicDiscovery { Id = 3 }
            );
        }
    }
}