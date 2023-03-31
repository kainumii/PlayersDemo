namespace PlayersDemo.Data.Models
{
    public class HolidayRespModel
    {
        public string Name { get; set; }

        public string LocalName { get; set; }

        public DateTime? Date { get; set; }

        public string CountryCode { get; set; }

        public bool Global { get; set; }

        public int? LaunchYear { get; set; }
    }
}
