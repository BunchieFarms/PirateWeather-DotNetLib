using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PirateWeather_DotNetLib
{
    public static class PirateForecast
    {
        public static async Task<PirateWeatherResponse> GetAsync(ForecastRequest request)
        {
            using (HttpClient client = new HttpClient())
            {
                PirateWeatherResponse response = await client.GetFromJsonAsync<PirateWeatherResponse>(request.BuildUri());
                return response;
            }
        }
    }
}
