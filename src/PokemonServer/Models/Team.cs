using System.Collections.Generic;

namespace PokemonServer.Models
{
    public class Team
    {
        public string Name { get; set; }
        public IEnumerable<Player> Players { get; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }
    }
}
