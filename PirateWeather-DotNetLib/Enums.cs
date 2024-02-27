namespace PirateWeather_DotNetLib
{
    public class Enums
    {
        public enum Unit
        {
            /// <summary>
            /// SI, with Wind Speed and Wind Gust in kilometres per hour.
            /// </summary>
            CA,

            /// <summary>
            /// SI, with Wind Speed and Wind Gust in miles per hour and visibility are in miles.
            /// </summary>
            UK,

            /// <summary>
            /// Imperial units (default)
            /// </summary>
            US,

            /// <summary>
            /// SI units.
            /// </summary>
            SI,
        }

        public enum DataGroup
        {
            /// <summary>
            /// Data from the current time.
            /// PAST DATA: Refers to the requested time and not the present time.
            /// </summary>
            Currently,

            /// <summary>
            /// Data on a minute-by-minute basis.
            /// PAST DATA: Not present except when querying data from the last three days.
            /// </summary>
            Minutely,

            /// <summary>
            /// Data on an hourly basis.
            /// PAST DATA: Will return data from midnight of the requested day to midnight the next day.
            /// </summary>
            Hourly,

            /// <summary>
            /// Daily Summary.
            /// PAST DATA: Will return the data for the current day except when querying data from the last three days.
            /// </summary>
            Daily,

            /// <summary>
            /// Weather alerts.
            /// PAST DATA: Not included.
            /// </summary>
            Alerts,
        }
    }
}
