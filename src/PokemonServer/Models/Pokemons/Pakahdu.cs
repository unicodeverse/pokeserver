using System;

namespace PokemonServer.Models.Pokemons
{
    public class Pakahdu : Pokemon
    {
        public Pakahdu(uint power)
            : base(power)
        {
        }

        /// <inheritdoc />
        public override Attack Attack()
        {
            return new Attack
            {
                AttackType = AttackType.Normal,
                Power = (uint)Math.Round((Power * 0.1d), 0),
            };
        }

        /// <inheritdoc />
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Pakahdu;
        }

        /// <inheritdoc />
        public override Attack PowerAttack()
        {
            return new Attack
            {
                AttackType = AttackType.Electric,
                Power = (uint)Math.Round((Power * 0.2d), 0),
            };
        }

        /// <inheritdoc />
        public override void ApplyAttack(Attack attack)
        {
            uint calculatedAttackDamage = attack.AttackType switch
            {
                AttackType.Electric => 0,
                _ => attack.Power,
            };

            HealthPoints -= calculatedAttackDamage;
        }
    }
}
