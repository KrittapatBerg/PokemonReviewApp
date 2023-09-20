using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategory
    {
        private DataContext _context;
        public CategoryRepository(DataContext context)
        {
             _context = context; 
        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.CategoryId == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(c => c.CategoryId == categoryId).Select(c => c.Pokemons).ToList();
        }
    }
}
