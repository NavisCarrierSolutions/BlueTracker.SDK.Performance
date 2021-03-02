using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query.Routing
{
    public class Weather
    {
        /// <summary>
        /// Cloud cover in percentage (%)
        /// </summary>
        public int Cloudcover { get; set; }

        /// <summary>
        /// Humidity in percentage
        /// </summary>
        public float Humidity { get; set; }

        /// <summary>
        /// Atmospheric pressure in millibars
        /// </summary>
        public int Pressure { get; set; }

        /// <summary>
        /// Significant wave height in metres
        /// </summary>
        public float SignificantWaveHeight { get; set; }

        /// <summary>
        /// Swell direction in degree
        /// </summary>
        public float SwellDirection { get; set; }

        /// <summary>
        /// Swell direction in 16-point compass
        /// </summary>
        public string SwellDirection16Point { get; set; }

        /// <summary>
        /// Swell wave height in metres
        /// </summary>
        public float SwellHeightMetres { get; set; }

        /// <summary>
        /// Swell wave height in feet
        /// </summary>
        public float SwellHeightFeet { get; set; }

        /// <summary>
        /// Swell period in seconds
        /// </summary>
        public float SwellPeriod { get; set; }

        /// <summary>
        /// Temperature in degree Celsius
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in degree Fahrenheit
        /// </summary>
        public int TemperatureF { get; set; }

        /// <summary>
        /// Local forecast time
        /// Time in hhmm. For example, 3am is 300.
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// Visibility in kilometres
        /// </summary>
        public int Visibility { get; set; }

        /// <summary>
        /// Water temperature in Celcius
        /// </summary>
        public int WaterTemperatureC { get; set; }

        /// <summary>
        /// Water temperature in Fahrenheit
        /// </summary>
        public int WaterTemperatureF { get; set; }

        /// <summary>
        /// Wind speed in miles per hour
        /// </summary>
        public int WindspeedMiles { get; set; }

        /// <summary>
        /// Wind speed in kilometres per hour
        /// </summary>
        public int WindspeedKmph { get; set; }

        /// <summary>
        /// Wind direction in degrees
        /// </summary>
        public int WindDirection { get; set; }

        /// <summary>
        /// Wind direction in 16-point compass
        /// </summary>
        public string WindDirection16Point { get; set; }

        /// <summary>
        /// Weather condition code
        /// </summary>
        public string WeatherConditionCode { get; set; }

        /// <summary>
        /// Weather condition description
        /// </summary>
        public List<WeatherDesc> WeatherConditionDescription { get; set; }

        /// <summary>
        /// URL to weather icon
        /// </summary>
        public List<WeatherIconUrl> WeatherIconUrls { get; set; }

        /// <summary>
        /// Precipitation (Niederschlag: Rain, Snow etc.) in millimetres
        /// </summary>
        public float Precipitation { get; set; }
    }

    public class WeatherDesc
    {
        public string value { get; set; }
    }

    public class WeatherIconUrl
    {
        public string value { get; set; }
    }
}