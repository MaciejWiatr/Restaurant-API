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


        /// <summary>
        ///     Get IEnumerable of random weather forecasts
        /// </summary>
        /// <param name="count">Number of forecasts function should return</param>
        /// <param name="minTemp">Minimal generated temperature</param>
        /// <param name="maxTemp">Maximal generated temperature</param>
        /// <returns> IEnumerable of WeatherForecast </returns>
        public IEnumerable<WeatherForecast> Get(int count, int minTemp, int maxTemp)
        {
            var rng = new Random();
            return Enumerable.Range(1, count).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(minTemp, maxTemp),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
