namespace Blazor.NETConf2024.Client.Services;

public class WeatherForecastClientService(HttpClient httpClient) : IWeatherForecastService
{
    public Task<IEnumerable<WeatherForecast>> GetListAsync()
    {
        return httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("weatherforecast")!;
    }
}