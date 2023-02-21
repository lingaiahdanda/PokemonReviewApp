using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;
using AutoMapper;
namespace PokemonReviewApp.Helper
{
    // used to map the DTO for Swagger
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
