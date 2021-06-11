using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisTournaments.Data.Models;

namespace TennisTournaments.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<PlayingCategory> PlayingCategories { get; set; }

        public DbSet<TournamentPlayingCategory> TournamentPlayingCategories { get; set; }

        public DbSet<PlayingIn> PlayingsIn { get; set; }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<RegistrationPlayer> RegistrationPlayers { get; set; }

        public DbSet<Fixture> Fixtures { get; set; }

        public DbSet<SetScore> SetScores { get; set; }

        public DbSet<GameScore> GameScores { get; set; }

        public DbSet<TieBreaker> TieBreakers { get; set; }

        public DbSet<FixtureResult> FixtureResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Fixture>()
                .HasOne(f => f.FirstRegistration)
                .WithMany(r => r.FirstFixtures)
                .HasForeignKey(f => f.FirstRegistrationId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Fixture>()
                .HasOne(f => f.SecondRegistration)
                .WithMany(r => r.SecondFixtures)
                .HasForeignKey(f => f.SecondRegistrationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
