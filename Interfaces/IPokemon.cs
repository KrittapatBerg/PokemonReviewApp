﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemon
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id); 
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeid);
    }
}
