using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPokemon.Data;
using System;
using System.Linq;

namespace MvcPokemon.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider service Provider)
        {
            using (var context = new MvcPokemonContext(
                ServiceProvider.GetRequiredService<DbContextOptions<MvcPokemonContext>>()))
                {
                    //Look for Pokemon
                    if (context.Pokemon.Any())
                    {
                        return; //DB has been seeded
                    }

                    context.Pokemon.AddRange(
                        new Pokemon
                        {
                            Name = "Bulbasaur",
                            Type = "Grass",
                            HP = Convert.ToInt32("200"),
                            EvolvesFrom = "A rock"
                        },

                        new Pokemon
                        {
                            Name = "Machomp",
                            Type = "Fighting",
                            HP = Convert.ToInt32("100"),
                            EvolvesFrom = "Machoke"  
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public string EvolvesFrom { get; set; }
    }
