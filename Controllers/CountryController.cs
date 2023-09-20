using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountry _countryRepo;
        private readonly IMapper _mapper;

        public CountryController(ICountry countryRepo, IMapper mapper)
        {
            _countryRepo = countryRepo;
            _mapper = mapper;
        }


    }
}
