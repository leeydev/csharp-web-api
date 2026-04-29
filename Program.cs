using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "csharp-web-api is running", version = "1.0.0" }));
app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

Console.WriteLine("csharp-web-api listening on http://localhost:5000");
app.Run();
