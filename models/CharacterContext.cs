using DNDApi.Models.Actions;
using Microsoft.EntityFrameworkCore;

namespace DNDApi.Models.Character
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public CharacterContext(DbContextOptions<CharacterContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.211.55.3;Database=DND;User Id=DND;Password=%5*r$BwVhREMYW3*;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().OwnsOne(p => p.Abilities);
            modelBuilder.Entity<Character>().OwnsOne(p => p.Saves);
            modelBuilder.Entity<Character>().OwnsOne(p => p.Skills);
            modelBuilder.Entity<Character>().OwnsOne(p => p.Speed);
            modelBuilder.Entity<Character>().OwnsMany(p => p.Actions, a =>
              {
                  a.OwnsOne(a => a.Attack, x =>
                  {
                      x.OwnsMany(p => p.Damage);
                  });
                  a.ToTable("Action");
              });
        }
    }
}
