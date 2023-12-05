using Konyvtar.Ui.Client;
using Konyvtar.Ui.Client.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Konyvtar.UI.Services;
using Konyvtar.Ui.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7290") });
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IBookServices, BookServices>();
builder.Services.AddScoped<IOutServices, OutService>();

await builder.Build().RunAsync();
