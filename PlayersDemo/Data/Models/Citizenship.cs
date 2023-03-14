using System.ComponentModel.DataAnnotations;

namespace PlayersDemo.Data.Models
{
    public class Citizenship
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public List<Player> CitizenShips { get; set; } = new();
    }
}
