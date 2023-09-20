using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviewRepository : IReview
    {
        private readonly DataContext _context;
        public ReviewRepository(DataContext context)
        {
            _context = context;       
        }
        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.ReviewId == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsForAPokemon(int pokeId)
        {
            return _context.Reviews.Where(r => r.Pokemons.PokemonId == pokeId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r => r.ReviewId == reviewId);
        }
    }
}
