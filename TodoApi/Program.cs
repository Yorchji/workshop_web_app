<<<<<<< HEAD
using TodoApi.Dtos;

=======
>>>>>>> origin/develop
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

<<<<<<< HEAD
var todos = new List<TodoGetDto>
{
    new TodoGetDto(1, "Learn C#", true),
    new TodoGetDto(2, "Build a web API", false),
    new TodoGetDto(3, "Profit!", false)
};

app.MapGet("/api/todos", () => Results.Ok(todos));

app.MapGet("/api/todos/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(t => t.Id == id);

    return todo;
    
});

app.Run();
=======
app.MapGet("/", () => "Hello Todo API");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
>>>>>>> origin/develop
