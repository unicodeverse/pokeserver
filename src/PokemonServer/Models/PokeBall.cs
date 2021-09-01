using System;

namespace PokemonServer.Models
{
    public class PokeBall
    {
        public PokeBallType PokeBallType { get; set; }

        public PokeBall(PokeBallType ballType)
        {
            PokeBallType = ballType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pokemon">The pokemon to catch.</param>
        /// <param name="throwQuality">How good the throw was (1-100)</param>
        /// <returns>True if pokemon catch succeeded, otherwise false.</returns>
        public bool Catch(Pokemon pokemon, uint throwQuality)
        {
            decimal multiplier = PokeBallType switch
            {
                PokeBallType.Basic => 1m,
                PokeBallType.Rare => 0.7m,
                PokeBallType.Epic => 0.3m,
                PokeBallType.Legendary => 0.1m,
                _ => throw new Exception($"Unknown PokeBallType {PokeBallType}"),
            };

            decimal power = pokemon.Power * 0.01m;

            return throwQuality > (power * multiplier);
        }
    }
}
