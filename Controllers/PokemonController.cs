using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.DTO;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemon _pokemonRepo;
        private readonly IMapper _mapper;

        //automapper is helping me taking data in & out 
        public PokemonController(IPokemon pokemonRepo, IMapper mapper)
        {
            _pokemonRepo = pokemonRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons() 
        { 
            var pokemons = _mapper.Map<List<PokemonDto>>(_pokemonRepo.GetPokemons());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }

        [HttpGet("{pokeId}")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeId)
        {
            if (!_pokemonRepo.PokemonExists(pokeId))
                return NotFound();

            var pokemon = _mapper.Map<PokemonDto>(_pokemonRepo.GetPokemon(pokeId));

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(pokemon);
        }

        [HttpGet("{pokeId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemonRating(int pokeId)
        {
            if(!_pokemonRepo.PokemonExists(pokeId))
                return NotFound();

            var rating = _pokemonRepo.GetPokemonRating(pokeId);

            if(!ModelState.IsValid) return BadRequest(); 
            
            return Ok(rating);
        }


    }
}
