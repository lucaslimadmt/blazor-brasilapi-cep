using BlazorWasmBrasilApiCep;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registra o HttpClient para consultas na BrasilAPI.
builder.Services.AddScoped(_ => new HttpClient
{
    BaseAddress = new Uri("https://brasilapi.com.br/")
});

await builder.Build().RunAsync();
