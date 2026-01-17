using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Configurations.Entities
{
    public class MyPlaylistSeed : IEntityTypeConfiguration<MyPlaylist>
    {
        public void Configure(EntityTypeBuilder<MyPlaylist> builder)
        {
            builder.HasData(
                new MyPlaylist
                {
                    Id = 1,
                    Name = "Chill Tunes",
                    Description = " ",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new MyPlaylist
                {
                    Id = 3,
                    Name = "Study Music",
                    Description = " ",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
