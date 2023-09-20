using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwner
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId );
        bool OwnerExists(int ownerId);
    }
}
