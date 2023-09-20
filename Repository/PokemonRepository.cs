using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemon
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.PokemonId == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.PokemonName == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemons.PokemonId == pokeId);

            if (review.Count() <= 0) return 0;
            return ((decimal)review.Sum(r => r.Rating) / review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.PokemonId).ToList();
        }

        public bool PokemonExists(int pokeid)
        {
            return _context.Pokemon.Any(p => p.PokemonId == pokeid); 
        }
    }
}
