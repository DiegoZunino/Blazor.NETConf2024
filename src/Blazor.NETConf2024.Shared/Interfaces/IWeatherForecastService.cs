namespace Blazor.NETConf2024.Shared.Interfaces;

public interface IWeatherForecastService
{
    Task<IEnumerable<WeatherForecast>> GetListAsync();
}