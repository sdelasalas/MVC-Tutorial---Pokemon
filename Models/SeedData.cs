using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPokemon.Data;
using System;
using System.Linq;

namespace MvcPokemon.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPokemonContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcPokemonContext>>()))
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
                            EvolvesFrom = "A rock",
                            Rating = "10"
                        },

                        new Pokemon
                        {
                            Name = "Machomp",
                            Type = "Fighting",
                            HP = Convert.ToInt32("100"),
                            EvolvesFrom = "Machoke",
                            Rating = "5"  
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }