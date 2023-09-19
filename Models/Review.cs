namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; } 

        public Reviewer Reviewers { get; set; }
        public Pokemon Pokemons { get; set; }
    }
}
