using Microsoft.OpenApi.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

using May.The.Fourth.Backend.Data.Interfaces;
using May.The.Fourth.Backend.Data.Repositories;
using May.The.Fourth.Backend.Services.Interfaces;
using May.The.Fourth.Backend.Services;
using May.The.Fourth.Backend.Data.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
{
    options.SwaggerDoc("v1", new OpenApiInfo 
    {
        Title = "Star Wars API",
        Version = "v1",
        Description = "An ASP.NET Core Web API for getting information about Star Wars world",
        TermsOfService = new Uri("https://star-wars-balta.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Paulo Pimenta",
            Url = new Uri("https://star-wars-balta.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Star Wars Balta License",
            Url = new Uri("https://star-wars-balta.com/license")
        }
    });
    // Add XML comments to swagger.
    // Using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
builder.Services.AddScoped<IPlanetRepository, PlanetRepository>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IStarshipRepository, StarshipRepository>();

builder.Services.AddScoped<IFilmeService, FilmeService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<IPlanetService, PlanetService>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IStarshipService, StarshipService>();

builder.Services.AddEntityFrameworkNpgsql();
var connection = builder.Configuration.GetConnectionString("StarWarsConnection");
builder.Services.AddDbContextPool<StarWarsContext>(options => options.UseNpgsql(connection));

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
app.UseSwagger();

// app.MapGet("/", () => "Hello World!");

// endpoints
var endpoints = app.MapGroup("/star-wars");
endpoints.MapGet("/", () => "Hello Star Wars World!");
endpoints.MapGet("/filmes", GetFilmes);
endpoints.MapGet("/characters", GetCharactersAsync);
endpoints.MapGet("/character/{id}", GetCharacterByIdAsync);

endpoints.MapGet("/planets", GetPlanetsAsync);
endpoints.MapGet("/planet/{id}", GetPlanetByIdAsync);

endpoints.MapGet("/vehicles", GetVehiclesAsync);
endpoints.MapGet("/vehicle/{id}", GetVehicleByIdAsync);

endpoints.MapGet("/starships", GetStarshipsAsync);
endpoints.MapGet("/starship/{id}", GetStarshipByIdAsync);

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Star Wars API");
    // Tip: To serve the Swagger UI at the app's root (https://localhost:<port>/), set the RoutePrefix property to an empty string
    options.RoutePrefix = string.Empty;
});

app.Run();

static async Task<IResult> GetFilmes(IFilmeService filmeService)
{
    var result = await filmeService.GetFilmes();
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetCharactersAsync(ICharacterService characterService)
{
    var result = await characterService.GetCharactersAsync();
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetCharacterByIdAsync(int id, ICharacterService characterService)
{
    var result = await characterService.GetCharacterByIdAsync(id);
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetPlanetsAsync(IPlanetService planetService)
{
    var result = await planetService.GetPlanetsAsync();
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetPlanetByIdAsync(int id, IPlanetService planetService)
{
    var result = await planetService.GetPlanetByIdAsync(id);
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetVehiclesAsync(IVehicleService vehicleService)
{
    var result = await vehicleService.GetVehiclesAsync();
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetVehicleByIdAsync(int id, IVehicleService vehicleService)
{
    var result = await vehicleService.GetVehicleByIdAsync(id);
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetStarshipsAsync(IStarshipService starshipService)
{
    var result = await starshipService.GetStarshipsAsync();
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}

static async Task<IResult> GetStarshipByIdAsync(int id, IStarshipService starshipService)
{
    var result = await starshipService.GetStarshipByIdAsync(id);
    return result.Success 
        ? TypedResults.Ok(result) 
        : TypedResults.BadRequest(result);
}
