 namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public Guid PokemonId { get; set; }  
        public string PokemonName { get; set;}
        public DateTime Birthdate { get; set; }
         
        public ICollection<Review> Reviews { get; set; } 
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; } 
    }
}
