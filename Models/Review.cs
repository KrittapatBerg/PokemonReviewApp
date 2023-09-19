namespace PokemonReviewApp.Models
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; } 

        public Reviewer Reviewers { get; set; }
        public Pokemon Pokemons { get; set; }
    }
}
