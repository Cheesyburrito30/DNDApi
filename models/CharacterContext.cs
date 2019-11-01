using Microsoft.EntityFrameworkCore;

namespace DNDApi.Models
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}