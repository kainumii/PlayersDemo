using System.ComponentModel.DataAnnotations;

namespace PlayersDemo.Data.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required,StringLength(100)]    
        public string? Name { get; set; }

        public List<Player> Players { get; set; } = new();
    }
}
