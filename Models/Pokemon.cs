
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPokemon.Models
{
    
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }

        [Display(Name = "Evolves From")]
        [DataType(DataType.Text)]
        public string EvolvesFrom { get; set; }
    }
}