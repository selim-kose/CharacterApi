using CharacterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterApi.Data {
    public class CharacterDbContext(DbContextOptions<CharacterDbContext> options) : DbContext(options){
        public DbSet<Character> Characters { get; set; }
    }
}
