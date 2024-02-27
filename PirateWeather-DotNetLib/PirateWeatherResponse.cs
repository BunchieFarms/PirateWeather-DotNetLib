namespace PirateWeather_DotNetLib
{
    public class PirateWeatherResponse
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Timezone { get; set; }
        public float Offset { get; set; }
        public int Elevation { get; set; }
        public Currently Currently { get; set; }
        public Minutely Minutely { get; set; }
        public Hourly Hourly { get; set; }
        public Daily Daily { get; set; }
        public Alert[] Alerts { get; set; }
        public Flags Flags { get; set; }
    }

    public class Currently
    {
        public int Time { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public int NearestStormDistance { get; set; }
        public int NearestStormBearing { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipIntensityError { get; set; }
        public string PrecipType { get; set; }
        public float Temperature { get; set; }
        public float ApparentTemperature { get; set; }
        public float DewPoint { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public float WindGust { get; set; }
        public int WindBearing { get; set; }
        public float CloudCover { get; set; }
        public float UVIndex { get; set; }
        public float Visibility { get; set; }
        public float Ozone { get; set; }
    }

    public class Minutely
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public MinutelyData[] Data { get; set; }
    }

    public class MinutelyData
    {
        public int Time { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipIntensityError { get; set; }
        public string PrecipType { get; set; }
    }

    public class Hourly
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public HourlyData[] Data { get; set; }
    }

    public class HourlyData
    {
        public int Time { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipIntensityError { get; set; }
        public float PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public float Pemperature { get; set; }
        public float ApparentTemperature { get; set; }
        public float DewPoint { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public float WindGust { get; set; }
        public int WindBearing { get; set; }
        public float CloudCover { get; set; }
        public float UVIndex { get; set; }
        public float Visibility { get; set; }
        public float Ozone { get; set; }
    }

    public class Daily
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public DailyData[] Data { get; set; }
    }

    public class DailyData
    {
        public int Time { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public int SunriseTime { get; set; }
        public int SunsetTime { get; set; }
        public float MoonPhase { get; set; }
        public float PrecipIntensity { get; set; }
        public float PrecipIntensityMax { get; set; }
        public int PrecipIntensityMaxTime { get; set; }
        public float PrecipProbability { get; set; }
        public float PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public float TemperatureHigh { get; set; }
        public int TemperatureHighTime { get; set; }
        public float TemperatureLow { get; set; }
        public int TemperatureLowTime { get; set; }
        public float ApparentTemperatureHigh { get; set; }
        public int ApparentTemperatureHighTime { get; set; }
        public float ApparentTemperatureLow { get; set; }
        public int ApparentTemperatureLowTime { get; set; }
        public float DewPoint { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float WindSpeed { get; set; }
        public float WindGust { get; set; }
        public int WindGustTime { get; set; }
        public int WindBearing { get; set; }
        public float CloudCover { get; set; }
        public float UVIndex { get; set; }
        public int UVIndexTime { get; set; }
        public float Visibility { get; set; }
        public float TemperatureMin { get; set; }
        public int TemperatureMinTime { get; set; }
        public float TemperatureMax { get; set; }
        public int TemperatureMaxTime { get; set; }
        public float ApparentTemperatureMin { get; set; }
        public int ApparentTemperatureMinTime { get; set; }
        public float ApparentTemperatureMax { get; set; }
        public int ApparentTemperatureMaxTime { get; set; }
    }

    public class Alert
    {
        public string Title { get; set; }
        public string[] Regions { get; set; }
        public string severity { get; set; }
        public int Time { get; set; }
        public int Expires { get; set; }
        public string Description { get; set; }
        public string URI { get; set; }
    }

    public class Flags
    {
        public string[] Sources { get; set; }
        public Sourcetimes SourceTimes { get; set; }
        public int Neareststation { get; set; }
        public string Units { get; set; }
        public string Version { get; set; }
    }

    public class Sourcetimes
    {
        public string hrrr_018 { get; set; }
        public string hrrr_subh { get; set; }
        public string hrrr_1848 { get; set; }
        public string gfs { get; set; }
        public string gefs { get; set; }
    }
}
