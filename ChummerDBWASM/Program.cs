using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ChummerDBWASM;
using ChummerDBWASM.Backend;
using MudBlazor.Services;
using Serilog;
using Serilog.Core;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var levelSwitch = new LoggingLevelSwitch();
Log.Logger = new LoggerConfiguration()
    .WriteTo.Debug()
    .WriteTo.BrowserConsole()
    .CreateLogger();
builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

builder.Services.AddSingleton(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

builder.Services.AddChummerDBServices();
builder.Services.AddTransient<IXmlDataProvider, XmlDataProvider>();
builder.Services.AddMudServices();

await builder.Build().RunAsync();