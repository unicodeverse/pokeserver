using PokemonServer.Models;

namespace PokemonServer.Dtos
{
    public class PokemonDto
    {
        /// <summary>
        /// Name of the pokemon.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// How powerfull the pokemon is. Value is between <see cref="Pokemon.MIN_POWER"/> and <see cref="Pokemon.MAX_POWER"/>.
        /// </summary>
        public uint Power { get; set; }

        /// <summary>
        /// Current health points of the pokemon.
        /// </summary>
        public uint HealthPoints { get; set; }

        /// <summary>
        /// Type of the pokemon <see cref="PokemonType"/>.
        /// </summary>
        public PokemonType PokemonType { get; set; }
    }
}