using Demo;

#region Initialize builder

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});

builder.Services
.AddHttpClient("rest",
    c => c.BaseAddress = new Uri("https://swapi.dev/"));

builder.Services
.AddGraphQLServer()
.AddQueryType<Query>()
.AddType<People>()
.InitializeOnStartup();

var app = builder.Build();
app.MapGraphQL();
app.Run();

#endregion