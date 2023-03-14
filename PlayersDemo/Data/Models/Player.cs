using System.ComponentModel.DataAnnotations;

namespace PlayersDemo.Data.Models
{
    public class Player
    {   
        public int Id { get; set; }

        [Required, StringLength(100)] 
        public string?  LastName { get; set; }
        
        [Required, StringLength (100)]
        public string? FirstName { get; set; }

        public bool IsRight { get; set; }

        [Required]
        public int? TeamId { get; set; }

        public Team? Team { get; set; }

        public Position Position { get; set; }

        [Required]
        public int? CitizenshipId { get; set; }
        
        public Citizenship? Citizenship { get; set; }
    }

    public enum Position
    { 
        GoalKeeper, Defender, Forward
    }
}
