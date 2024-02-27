using PirateWeather_DotNetLib;
using static PirateWeather_DotNetLib.Enums;

class Program
{
    public static async Task Main()
    {
        ForecastRequest req = new ForecastRequest
        {
            ApiKey = "[Key]",
            Location = new Location(34, -77),
            Time = new Time(2),
            Include = new List<DataGroup> { DataGroup.Daily },
            Unit = Unit.UK,
            Extend = true
        };
        PirateWeatherResponse response = await PirateForecast.GetAsync(req);
    }
}