namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        public Guid ReviwerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Review> Reviews { get; set;}
    }
}
