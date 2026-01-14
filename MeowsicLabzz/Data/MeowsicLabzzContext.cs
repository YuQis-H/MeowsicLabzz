using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeowsicLabzz.Components.Domain;

namespace MeowsicLabzz.Data
{
    public class MeowsicLabzzContext : DbContext
    {
        public MeowsicLabzzContext (DbContextOptions<MeowsicLabzzContext> options)
            : base(options)
        {
        }

        public DbSet<MeowsicLabzz.Components.Domain.Songs> Songs { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.Albums> Albums { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.Users> Users { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.Recommendations> Recommendations { get; set; } = default!;
        public DbSet<MeowsicLabzz.Components.Domain.MyPlaylist> MyPlaylist { get; set; } = default!;
    }
}
