using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ChummerDBWASM;
using ChummerDBWASM.Backend;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

builder.Services.AddChummerDBServices();
builder.Services.AddSingleton<IXmlLoadManager, XmlLoadManager>();
builder.Services.AddMudServices();

await builder.Build().RunAsync();