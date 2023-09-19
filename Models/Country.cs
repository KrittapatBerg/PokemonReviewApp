namespace PokemonReviewApp.Models
{
    public class Country
    {
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }

        public ICollection<Owner> Owners { get; set;}
    }
}
