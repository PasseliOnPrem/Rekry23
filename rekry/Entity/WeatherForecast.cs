namespace Entity;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int? TemperatureC { get; set; }

    public int? TemperatureF => TemperatureC.HasValue ? 32 + (int)(TemperatureC / 0.5556) : null;
    public string? City { get; set; }
}
