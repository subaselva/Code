using BlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Application.Services;
using Application.Interface;
using Infrastructure.Repositories;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7127/") });
builder.Services.AddScoped<IUnitCostService, UnitCostService>();
builder.Services.AddScoped<IUnitCostRepository, UnitCostRepository>();

await builder.Build().RunAsync();
