using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategory 
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
    }
}
