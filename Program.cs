using System.Net.WebSockets;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Need to add services to the container
builder.Services.AddControllers();

//This will hook up the database context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    Console.WriteLine(db.Database.CanConnect() ? "DB Connected" : "DB Failed");
}
app.MapControllers();

app.Run();