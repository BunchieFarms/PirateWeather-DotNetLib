using System;
using System.Collections.Generic;
using static PirateWeather_DotNetLib.Enums;

namespace PirateWeather_DotNetLib
{
    public class ForecastRequest
    {
        /// <summary>
        /// Required, Api Key for Pirate Weather.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Defaults to false, but Time Machine uses the https://timemachine.pirateweather.net URI, and is updated monthly.
        /// You can still search a few days back with the regular API.
        /// </summary>
        public bool IsTimeMachine { get; set; } = false;

        /// <summary>
        /// Latitude and Longitude.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Time is not required for standard API requests.
        /// You cannot request into the future.
        /// You can request a few days in the past with the standard API, and further back with the Time Machine API.
        /// </summary>
        public Time Time { get; set; } = null;

        /// <summary>
        /// You can exclude currently, minutely, hourly, daily, and alerts from the query.
        /// If both Include and Exclude are included in the request, Include will be ignored.
        /// Do so with the "Exclude" enum
        /// </summary>
        public List<DataGroup> Exclude { get; set; } = new List<DataGroup>();

        /// <summary>
        /// You can include currently, minutely, hourly, daily, and alerts from the query.
        /// If both Include and Exclude are included in the request, Include will be ignored.
        /// Do so with the "Exclude" enum
        /// </summary>
        public List<DataGroup> Include { get; set; } = new List<DataGroup>();

        /// <summary>
        /// Unit defaults to US.
        /// </summary>
        public Unit Unit { get; set; } = Unit.US;

        /// <summary>
        /// If set to true, hourly data for the next 168 hours will be included, instead of the standard 48!
        /// </summary>
        public bool Extend { get; set; } = false;

        public ForecastRequest() { }

        public ForecastRequest(string apiKey, Location location)
        {
            ApiKey = apiKey;
            Location = location;
        }
    }

    public class Location
    {
        internal double? Latitude { get; set; }
        internal double? Longitude { get; set; }
        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public class Time
    {
        internal int UTCTimeStamp { get; set; }

        /// <summary>
        /// Number of days ago you would like to query. Converts to UTC timestamp.
        /// </summary>
        public Time(int daysAgo)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime xDaysAgo = DateTime.Now.AddDays(-daysAgo);
            UTCTimeStamp = (int)(xDaysAgo - epoch).TotalSeconds;
        }

        /// <summary>
        /// DateTime of when you'd like to query. Converts to UTC timestamp.
        /// </summary>
        public Time(DateTime dateTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            UTCTimeStamp = (int)(dateTime - epoch).TotalSeconds;
        }
    }
}
