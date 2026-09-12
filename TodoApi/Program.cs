using TodoApi.Dtos;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


var todos = new List<TodoGetDto>
{
    new TodoGetDto(1, "Learn C#", true),
    new TodoGetDto(2, "Build a web API", false),
    new TodoGetDto(3, "Profit!", false)
};


app.MapGet("/api/todos", () =>
{
    return Results.Ok(todos);
});


app.MapGet("/api/todos/{id}", (int id) =>
{
    var todo = todos.FirstOrDefault(todo => todo.Id == id);

    if (todo == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(todo);
});

app.Run();