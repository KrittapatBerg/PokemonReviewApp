using AutoMapper;
using PokemonReviewApp.DTO;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>(); 
        }
    }
}
