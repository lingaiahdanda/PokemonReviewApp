using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;
using AutoMapper;
namespace PokemonReviewApp.Helper
{
    // used to map the Objects
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
        }
    }
}
