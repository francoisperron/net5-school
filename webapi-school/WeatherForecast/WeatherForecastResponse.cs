using System;

namespace School.WeatherForecast
{
    public class WeatherForecastResponse
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }
        
        public string Summary { get; set; }
    }
}