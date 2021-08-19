using Microsoft.AspNetCore.Mvc;
using PokemonServer.Dtos;
using PokemonServer.Models;
using System;

namespace PokemonServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(PlayerDto playerDto)
        {
            var player = new Player(playerDto.Name)
            {
                Id = Guid.NewGuid()
            };

            // Tallentaa pelaaja tietovarastoon. 

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(PlayerDto playerDto)
        {
            // Ladata pelaaja tietovarastosta

            // Päivittää pelaajan tiedot

            // Palauttaa OK
            return Ok();
        }
    }
}
