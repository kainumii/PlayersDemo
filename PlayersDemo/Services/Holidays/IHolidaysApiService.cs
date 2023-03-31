using PlayersDemo.Data.Models;

namespace PlayersDemo.Services.Holidays
{
    public interface IHolidaysApiService
    {
        public Task<List<HolidayRespModel>> GetHolidays(HolidayReqModel model);
    }
}
