using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorExample;
using BlazorExample.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(new LoggingService(LoggingService.LogLevel.INFO));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5091") });

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

await builder.Build().RunAsync();
