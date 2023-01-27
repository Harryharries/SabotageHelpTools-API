using Microsoft.EntityFrameworkCore;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        //public DbSet<Action> Actions { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<TurnAction> TurnActions { get; set; }

        public DbSet<Reviewer> Reviewers { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<CharacterTurnAction> CharacterTurnActions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterTurnAction>().HasKey(ct => new { ct.CharacterId, ct.TurnActionId });
            modelBuilder.Entity<CharacterTurnAction>()
                .HasOne(c => c.Character)
                .WithMany(ct => ct.CharacterTurnActions)
                .HasForeignKey(ct => ct.CharacterId);
            modelBuilder.Entity<CharacterTurnAction>()
                .HasOne(c => c.TurnAction)
                .WithMany(ct => ct.CharacterTurnAction)
                .HasForeignKey(t => t.TurnActionId);

        }
    }
}
