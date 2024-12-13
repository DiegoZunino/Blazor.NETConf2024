var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddHttpClient<IWeatherForecastService, WeatherForecastClientService>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

await builder.Build().RunAsync();