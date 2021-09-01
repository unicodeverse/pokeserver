using System;

namespace PokemonServer.Models
{
    public class Player
    {
        public const uint MAX_PLAYER_LEVEL = 100;
        public const uint MIN_PLAYER_LEVEL = 1;

        public Guid Id { get; set; }
        public string Name { get; private set; }
        public Team PlayerTeam { get; set; }

        /// <summary>
        /// Describes how powerful the player is. Scale is between <see cref="MIN_PLAYER_LEVEL"/> to <see cref="MAX_PLAYER_LEVEL"/>.
        /// </summary>
        public uint Level { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
