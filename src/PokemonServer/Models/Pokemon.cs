namespace PokemonServer.Models
{
    public class Pokemon
    {
        public string Name { get; private set; }
        public PokemonType PokemonType { get; private set; }

        public Pokemon(string name, PokemonType pokemonType)
        {
            Name = name;
            PokemonType = pokemonType;
        }
    }
}
