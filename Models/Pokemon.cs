
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPokemon.Models
{
    
    public class Pokemon
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength =3)]
        [Required]
        public string Name { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Type { get; set; }
        public int HP { get; set; }

        [Display(Name = "Evolves From")]
        [DataType(DataType.Text)]
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string EvolvesFrom { get; set; }

        public string Rating {get; set;}
    }
}