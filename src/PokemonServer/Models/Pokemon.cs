namespace PokemonServer.Models
{
    /// <summary>
    /// Abstract pokemon base class. This class must be derived by all the implemented 
    /// pokemons in the game.
    /// </summary>
    public abstract class Pokemon
    {
        public const uint MAX_POWER = 10000;
        public const uint MIN_POWER = 1;

        /// <summary>
        /// Name of the pokemon.
        /// </summary>
        public string Name
        {
            get
            {
                return GetPokemonType().ToString();
            }
        }

        /// <summary>
        /// Presents the attack power and the overall power of the pokemon.
        /// In a scale of 1 to 10 000.
        /// </summary>
        public uint Power { get; set; }

        /// <summary>
        /// Health of the pokemon.
        /// </summary>
        public uint HealthPoints { get; set; }

        /// <summary>
        /// Creates new pokemon instance.
        /// </summary>
        /// <param name="power">Overall power of the pokemon.</param>
        public Pokemon(uint power)
        {
            Power = power;
        }

        /// <summary>
        /// Perform a pokemon attack.
        /// </summary>
        /// <returns>Attack details.</returns>
        public abstract Attack Attack();

        /// <summary>
        /// Perform a powerful pokemon attack aka special.
        /// </summary>
        /// <returns>Power attack details.</returns>
        public abstract Attack PowerAttack();

        /// <summary>
        /// Returns the pokemon type.
        /// </summary>
        /// <returns>Pokemon type.</returns>
        public abstract PokemonType GetPokemonType();

        /// <summary>
        /// Applies the given attack against the pokemon.
        /// </summary>
        /// <param name="attack">Attack that is hit against the pokemon.</param>
        public abstract void ApplyAttack(Attack attack);
    }
}
