using System.Text;

namespace PirateWeather_DotNetLib
{
    public static class UriBuilder
    {
        internal static string BuildUri(this ForecastRequest request)
        {
            if (request.ApiKey == null) return string.Empty;

            if (!request.Location.LocationValid()) return string.Empty;

            StringBuilder uriBuilder = new StringBuilder();
            uriBuilder.Append(request.IsTimeMachine ? Constants.TimeMachineUri : Constants.ForecastUri);

            uriBuilder.Append($"{request.ApiKey}/");

            uriBuilder.Append($"{request.Location.Latitude},{request.Location.Longitude}");

            if (request.Time != null)
                uriBuilder.Append($",{request.Time.UTCTimeStamp}");

            if (request.Exclude.Count > 0)
                uriBuilder.Append($"?exclude={string.Join(",", request.Exclude).ToLowerInvariant()}");

            uriBuilder.Append($"&units={request.Unit}");

            if (request.Extend)
                uriBuilder.Append("&extend=hourly");

            return uriBuilder.ToString();
        }

        internal static bool LocationValid(this Location location)
        {
            if (location == null) return false;
            if (location.Longitude == null || location.Latitude == null) return false;
            if (location.Latitude > 360 || location.Longitude > 360) return false;
            if (location.Longitude > 180 && location.Latitude < 0) return false;
            if (location.Latitude > 180 && location.Longitude < 0) return false;
            return true;
        }
    }
}
