
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPokemon.Models
{
    
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public string EvolvesFrom { get; set; }
    }
}