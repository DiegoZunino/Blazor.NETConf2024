var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddHttpClient<IWeatherForecastService, WeatherForecastClientService>(client => client.BaseAddress = new Uri("http://localhost:5297/"));

await builder.Build().RunAsync();