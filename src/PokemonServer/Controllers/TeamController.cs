using Microsoft.AspNetCore.Mvc;
using PokemonServer.Dtos;
using PokemonServer.Models;

namespace PokemonServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(TeamDto teamDto)
        {
            var team = new Team(teamDto.Name);

            return Ok();
        }
    }
}
