using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemon
    {
        ICollection<Pokemon> GetPokemons();
    }
}
