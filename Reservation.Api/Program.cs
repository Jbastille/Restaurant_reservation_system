using System.Net.WebSockets;
using Microsoft.EntityFrameworkCore;
using Reservation.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

//Need to add services to the container
builder.Services.AddControllers();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5081")
});

//This will hook up the database context .... connect to the database VERY IMPORTANT!
builder.Services.AddDbContext<AppDbContext>(options =>
{
   options.UseSqlite(
    builder.Configuration.GetConnectionString("DefaultConnection"));
    
});

var app = builder.Build();

// Force detailed exception responses in REST extensions / local testing
app.UseDeveloperExceptionPage();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    Console.WriteLine(db.Database.CanConnect() ? "DB Connected" : "DB Failed");
}
app.MapControllers();

app.Run();