using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Blazor_NETConf2024_Api>("blazor-netconf2024-api");
builder.AddProject<Projects.Blazor_NETConf2024>("blazor-netconf2024")
    .WithReference(api)
    .WithExternalHttpEndpoints();

builder.Build().Run();
