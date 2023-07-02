using ChummerDB.Backend.Data;
using Microsoft.Extensions.Logging;
using ChummerDB.Models;
using ChummerDB.ViewModels;
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
        
        builder.Services.AddTransient<WeatherForecastService>();
        builder.Services.AddTransient<FetchDataViewModel>();
        builder.Services.AddTransient<HexEntryViewModel>();
        builder.Services.AddTransient<TextEntryViewModel>();
        builder.Services.AddTransient<SpellsViewModel>();
        builder.Services.AddSingleton<ISpellsModel, SpellsModel>();
        builder.Services.AddSingleton<XmlLoadManager>();

        return builder.Build();
    }
}

