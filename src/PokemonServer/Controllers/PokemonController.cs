using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonServer.Models;
using System;

namespace PokemonServer.Controllers
{
    /// <summary>
    /// Contains methods to create pokemons.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IMapper mapper;

        public PokemonController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        /// <summary>
        /// Create new random pokemon that matches the given player level. 
        /// For example player level 50 will receive pokemons with power of 1 to 5000.
        /// </summary>
        /// <param name="playerLevel">The current player level.</param>
        /// <returns>New random pokemon.</returns>
        [HttpPost]
        public IActionResult CreateRandom(int playerLevel)
        {
            if(playerLevel > Player.MAX_PLAYER_LEVEL || playerLevel < Player.MIN_PLAYER_LEVEL)
            {
                return BadRequest($"Player level must be between {Player.MIN_PLAYER_LEVEL} and {Player.MAX_PLAYER_LEVEL}");
            }

            var random = new Random();
            uint pokemonPower = (uint)random.Next(1, playerLevel * 100);
            var pokemonTypeIndex = random.Next(0, Enum.GetValues<PokemonType>().Length - 1);

            var pokemon = PokemonFactory.Create(Enum.GetValues<PokemonType>()[pokemonTypeIndex], pokemonPower);

            return Ok(pokemon);
        }
    }
}
