using PokemonServer.Models.Pokemons;
using System;

namespace PokemonServer.Models
{
    /// <summary>
    /// Use this class to create new instances of pokemons.
    /// </summary>
    public static class PokemonFactory
    {
        /// <summary>
        /// Creates the given type of pokemon.
        /// </summary>
        /// <param name="pokemonType">Pokemon type to create.</param>
        /// <param name="power">How powerfull the pokemon is.</param>
        /// <returns>new pokemon.</returns>
        public static Pokemon Create(PokemonType pokemonType, uint power) => pokemonType switch
        {
            PokemonType.Pakahdu => new Pakahdu(power),
            _ => throw new ArgumentOutOfRangeException(nameof(pokemonType), $"Unsupported pokemon type {pokemonType}."),
        };
    }
}
