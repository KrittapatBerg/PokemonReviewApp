namespace PokemonReviewApp.Models
{
    public class PokemonCategory
    {
        public Guid PokemonId { get; set; }
        public Guid CategoryId { get; set; }
        public Pokemon Pokemons { get; set; }
        public Category Category { get; set; }
    }
}
