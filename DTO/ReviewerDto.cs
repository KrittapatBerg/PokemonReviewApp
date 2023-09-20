using PokemonReviewApp.Models;

namespace PokemonReviewApp.DTO
{
    public class ReviewerDto
    {
        public int ReviwerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
