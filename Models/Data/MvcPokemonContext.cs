using Microsoft.EntityFrameworkCore;
using MvcPokemon.Models;

namespace MvcPokemon.Data
{
    public class MvcPokemonContext : DbContext
    {
        public MvcPokemonContext (DbContextOptions<MvcPokemonContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> Pokemon { get; set; }
    }
}