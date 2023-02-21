using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Pokemon>))]

        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();

            //ModelState is like when you send the wrong data to API, this model states finds that 
            //you sent the worng data
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //return the result
            return Ok(pokemons);
        }
    }
}
