using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) app.MapOpenApi();

app.UseHttpsRedirection();

//Root endpoint

// Defines a GET endpoints for the root path
app.MapGet("/", () => "WEB API is operational").WithName("GetDefaultResponse");

// greetings endpoint


// Defines a GET endpoint for the root path
app.MapGet("/greetings", (string? firstName, string? lastName) =>
{
    var developer = !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)
        ? new Developer(firstName, lastName)
        : null;
    var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
    return Results.Ok(response);
}).WithName("GetGreeting");

// greetings endpoint


// Defines a POST endpoint for creating a greeting
app.MapPost("/greetings", (GreetDeveloperRequest request) =>
{
    var developer = DeveloperAssembler.ToEntityFromRequest(request);
    var response = GreetDeveloperAssembler.ToResponseFromEntity(developer);
    return Results.Created("/greetings", response);
}).WithName("CreateGreetings");
app.Run();