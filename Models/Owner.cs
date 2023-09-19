namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public Guid OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Gym { get; set; }

        public Country Country { get; set; }  //one to one relation

        public ICollection<PokemonOwner> PokemonOwners { get; set; }   

    }
}
