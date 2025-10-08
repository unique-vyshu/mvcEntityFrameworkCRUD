using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsForProject;
using RepositoryForProject;


namespace TeamPlayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerWithDIController : ControllerBase
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerWithDIController(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllPlayers()
        {
            var players = await playerRepository.GetAllPLayers();
            return Ok(players);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetPlayerById(int id)
        {
            var player = await playerRepository.GetPlayerById(id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(Player player)
        {
            var newPlayer = await playerRepository.AddPlayer(player);
            return CreatedAtAction(nameof(GetPlayerById), new { id = newPlayer.Id }, newPlayer);
        }
    }
}
