using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcPokemon.Models
{
    public class PokemonTypeViewModel
    {
        public List<Pokemon> Pokemons {get; set;}
        public SelectList Types {get; set;}
        public string PokemonType {get; set;}
        public string SearchString {get; set;}

    }
}