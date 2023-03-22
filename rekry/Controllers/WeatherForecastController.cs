using Microsoft.AspNetCore.Mvc;
using Entity;
using Data;
using Dto;

namespace rekry.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly DataContext _dataContext;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, DataContext dataContext)
    {
        _logger = logger;
        _dataContext = dataContext;
    }

    [HttpGet]
    public IEnumerable<WeatherForecastDto> Get(int n = 3)
    {
        return _dataContext.Weather.Select(x => new WeatherForecastDto()
        {
            Date = x.Date,
            TemperatureC = x.TemperatureC,
            TemperatureF = x.TemperatureF,
            City = x.City,
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).Take(n);
    }
}
