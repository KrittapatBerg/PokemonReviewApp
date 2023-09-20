using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountry
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id); 

    }
}
