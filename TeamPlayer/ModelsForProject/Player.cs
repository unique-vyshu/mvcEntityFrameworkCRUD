using System.Text.Json.Serialization;

namespace ModelsForProject
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        [JsonIgnore]
        public Team? Team { get; set; }
    }
}
