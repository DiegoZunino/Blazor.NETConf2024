var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddCors();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors(x => x.AllowAnyOrigin());

app.MapGet("/weatherforecast", async (IWeatherForecastService weatherForecastService) => await weatherForecastService.GetListAsync()
).WithName("GetWeatherForecastList");

app.Run();