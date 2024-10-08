﻿namespace PirateWeather_DotNetLib
{
    public class PirateWeatherResponse
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Timezone { get; set; }
        public double Offset { get; set; }
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
        public double NearestStormDistance { get; set; }
        public double NearestStormBearing { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
        public string PrecipType { get; set; }
        public double Temperature { get; set; }
        public double ApparentTemperature { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UVIndex { get; set; }
        public double Visibility { get; set; }
        public double Ozone { get; set; }
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
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
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
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
        public double PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public double Pemperature { get; set; }
        public double ApparentTemperature { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UVIndex { get; set; }
        public double Visibility { get; set; }
        public double Ozone { get; set; }
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
        public double MoonPhase { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipIntensityMax { get; set; }
        public int PrecipIntensityMaxTime { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public double TemperatureHigh { get; set; }
        public int TemperatureHighTime { get; set; }
        public double TemperatureLow { get; set; }
        public int TemperatureLowTime { get; set; }
        public double ApparentTemperatureHigh { get; set; }
        public int ApparentTemperatureHighTime { get; set; }
        public double ApparentTemperatureLow { get; set; }
        public int ApparentTemperatureLowTime { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public int WindGustTime { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UVIndex { get; set; }
        public int UVIndexTime { get; set; }
        public double Visibility { get; set; }
        public double TemperatureMin { get; set; }
        public int TemperatureMinTime { get; set; }
        public double TemperatureMax { get; set; }
        public int TemperatureMaxTime { get; set; }
        public double ApparentTemperatureMin { get; set; }
        public int ApparentTemperatureMinTime { get; set; }
        public double ApparentTemperatureMax { get; set; }
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
