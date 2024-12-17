namespace Blazor.NETConf2024.Client.Pages;

public partial class Weather(IWeatherForecastService weatherForecastService)
{
    private IEnumerable<WeatherForecast>? _forecasts;

    protected override async Task OnInitializedAsync()
    {
        if(RendererInfo.IsInteractive) // || (!RendererInfo.IsInteractive && AssignedRenderMode is null))
        {
            _forecasts = await weatherForecastService.GetListAsync();
        }
    }
}