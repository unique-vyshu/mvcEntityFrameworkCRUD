using Microsoft.EntityFrameworkCore;
using ModelsForProject;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ContextForProject
{
    public class PlayerTeamDataContext:DbContext
    {
        public PlayerTeamDataContext(DbContextOptions<PlayerTeamDataContext> options) : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Team A", Description = "This is Team A" },
                new Team { Id = 2, Name = "Team B", Description = "This is Team B" }
            );
        }
    }
}
