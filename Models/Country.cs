﻿namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public ICollection<Owner> Owners { get; set;}
    }
}
