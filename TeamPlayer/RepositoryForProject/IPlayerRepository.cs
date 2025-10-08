using ModelsForProject;

namespace RepositoryForProject
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetAllPLayers();
        Task<Player?> GetPlayerById(int id);
        Task<Player> AddPlayer(Player player);
        string UpdatePlayer(Player player);
        string DeletePlayer(int id);
    }
}