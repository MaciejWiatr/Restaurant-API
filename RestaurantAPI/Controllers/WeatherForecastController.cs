using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("currentDay/{max}")]
        public string GetCurrentDay([FromQuery] int take, [FromRoute] int max)
        {
            return $"Max wynosi: {max} a take to {take}";
        }

        [HttpPost]
        public ActionResult<string> Hello([FromBody] string name)
        {
            return NotFound("Lol, nie znaleziono");
        }

        [HttpPost("generate")]
        public ActionResult<IEnumerable<WeatherForecast>> Generate([FromQuery] int count, [FromBody] TemperatureRequest request)
        {
            if (count < 0 || request.Max < request.Min)
            {
                return BadRequest();
            }
            _logger.LogDebug("Test");
            return Ok(_service.Get(count, request.Min, request.Max));
        }
    }
}
