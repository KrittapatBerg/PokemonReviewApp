using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CountryRepository : ICountry
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context)
        {
            _context = context;
        }
        public bool CountryExists(int id)
        {
           return _context.Countries.Any(c => c.CountryId == id);
        }

        public ICollection<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Where(c => c.CountryId == id).FirstOrDefault();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            return _context.Owners.Where(c => c.OwnerId == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            return _context.Owners.Where(c => c.Country.CountryId == countryId).ToList();
        }
    }
}
