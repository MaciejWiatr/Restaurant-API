using System.Collections.Generic;

namespace RestaurantAPI
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int resultAmount, int minTemp, int maxTemp);
    }
}
