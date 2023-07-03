using ChummerDB.Backend;
using ChummerDBRazorLibrary.Backend.Services;
using Microsoft.Extensions.Logging;
using ChummerDBRazorLibrary.Interfaces;
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
        builder.Services.AddSingleton<IXmlLoadManager, XmlLoadManager>();

        return builder.Build();
    }
}

