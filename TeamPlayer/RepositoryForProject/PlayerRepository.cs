using ContextForProject;
using Microsoft.EntityFrameworkCore;
using ModelsForProject;

namespace RepositoryForProject
{
    public class PlayerRepository: IPlayerRepository
    {
        private readonly PlayerTeamDataContext _context;
        public PlayerRepository(PlayerTeamDataContext context)
        {
            _context = context;
        }

        public async Task<List<Player>> GetAllPLayers()
        {
            var players = await _context.Players.ToListAsync();
            return players;
        }

        public async Task<Player?> GetPlayerById(int id)
        {
            var player = await _context.Players.FindAsync(id);
            return player;
        }

        public async Task<Player> AddPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }

        public string UpdatePlayer(Player player)
        {
            _context.Entry(player).State = EntityState.Modified;
            _context.SaveChanges();
            return "Updated  successfully";
        }

        public string DeletePlayer(int id)
        {
            var player = _context.Players.Find(id);
            if (player != null)
            {
                _context.Players.Remove(player);
                _context.SaveChanges();
                return "Deleted successfully";
            }
            return "Player not found";

        }
    }
}
