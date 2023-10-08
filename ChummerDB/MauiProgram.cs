using ChummerDB.Backend;
using ChummerDB.Shared.Interfaces;
using ChummerDB.Shared.Services;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace ChummerDB;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });
        

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();
        
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        builder.Services.AddChummerDBServices();
        // This needs to be provided for the RCL
        builder.Services.AddTransient<IXmlDataProvider, XmlDataProvider>();

        return builder.Build();
    }
}

