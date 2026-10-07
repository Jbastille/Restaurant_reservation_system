using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ReservationSystem.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Use simple <App> now that @namespace ReservationSystem.Client is set in App.razor
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5081/") });

await builder.Build().RunAsync();