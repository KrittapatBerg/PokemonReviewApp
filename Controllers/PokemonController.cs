using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]/action")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemon _pokemonRepo;
        public PokemonController(IPokemon pokemonRepo)
        {
            _pokemonRepo = pokemonRepo;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons() 
        { 
            var pokemons = _pokemonRepo.GetPokemons();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }
    }
}
