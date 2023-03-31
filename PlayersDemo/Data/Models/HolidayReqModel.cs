using System.ComponentModel.DataAnnotations;

namespace PlayersDemo.Data.Models
{
    public class HolidayReqModel
    {
        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string? CountryCode { get; set; }

        [Required]
        [Range(2000, 2100, ErrorMessage = "Year must be between 2000 and 2100")]
        public int Year { get; set; }
    }
}
