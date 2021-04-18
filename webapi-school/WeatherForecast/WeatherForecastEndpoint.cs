using System;
using System.Collections.Generic;
using System.Linq;

namespace School.WeatherForecast
{
    public class WeatherForecastEndpoint
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        public IEnumerable<WeatherForecastResponse> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5)
                .Select(index => BuildResponse(index, rng))
                .ToArray();
        }

        private static WeatherForecastResponse BuildResponse(int index, Random rng) =>
            new()
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            };
    }
}