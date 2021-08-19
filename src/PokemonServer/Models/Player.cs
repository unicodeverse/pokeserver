using System;

namespace PokemonServer.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public Team PlayerTeam { get; private set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
