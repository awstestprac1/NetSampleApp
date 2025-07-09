using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "✅ Hello from the remote .NET Web App!");

app.Run("http://0.0.0.0:5000");

public partial class Program { }