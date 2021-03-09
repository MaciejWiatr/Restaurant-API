using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantAPI
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
               {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> Get(int resultAmount, int minTemp, int maxTemp)
        {
            var rng = new Random();
            return Enumerable.Range(1, resultAmount).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(minTemp, maxTemp),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
