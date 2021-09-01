using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonServer.Models;
using PokemonServer.Models.Pokemons;

namespace PokemonServerTests.Models
{
    [TestClass]
    public class PokeBallTests
    {
        [TestMethod]
        public void Catch_WithSuccessfullThrow_ShouldCatchThePokemon()
        {
            // Arrange
            var ball = new PokeBall(PokeBallType.Basic);
            var pokemon = new Pakahdu("Testi", 100);

            // Act
            var pokemonCatched = ball.Catch(pokemon, 100);

            // Assert
            Assert.IsTrue(pokemonCatched, "Low level pokemon should be catch with perfect throw.");
        }
    }
}
