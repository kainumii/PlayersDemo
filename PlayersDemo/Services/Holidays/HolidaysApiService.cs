using PlayersDemo.Data.Models;
using System.Text.Json;

namespace PlayersDemo.Services.Holidays
{
    public class HolidaysApiService : IHolidaysApiService
    {
        private IHttpClientFactory _httpClientFactory;
        
        public HolidaysApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<HolidayRespModel>> GetHolidays(HolidayReqModel model)
        {
            var result = new List<HolidayRespModel>();
            var req = new HttpRequestMessage(HttpMethod.Get, $"https://date.nager.at/api/v3/PublicHolidays/{model.Year}/{model.CountryCode}");
            req.Headers.Add("Accept", "application/json");

            var client = _httpClientFactory.CreateClient();
            var resp = await client.SendAsync(req);

            if (resp.IsSuccessStatusCode)
            {

                var stringJson = await resp.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                result = JsonSerializer.Deserialize<List<HolidayRespModel>>(stringJson, options);               
            }

            return result;
        }
    }
}
