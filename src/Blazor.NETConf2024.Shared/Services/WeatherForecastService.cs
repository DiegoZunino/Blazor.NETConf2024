namespace Blazor.NETConf2024.Shared.Services;

public class WeatherForecastService: IWeatherForecastService
{
    private readonly string[] _summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];
    
    public Task<IEnumerable<WeatherForecast>> GetListAsync()
    {
        return Task.FromResult(
            Enumerable.Range(1, 5).Select(idx => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now).AddDays(idx),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = _summaries[Random.Shared.Next(_summaries.Length)]
            })
        );
    }
}