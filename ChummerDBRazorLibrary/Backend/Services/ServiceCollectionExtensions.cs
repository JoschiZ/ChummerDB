using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.ViewModels;
using ChummerDBRazorLibrary.Models;
using ChummerDBRazorLibrary.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using HexEntryViewModel = ChummerDBRazorLibrary.Backend.ViewModels.HexEntryViewModel;
using TextEntryViewModel = ChummerDBRazorLibrary.Backend.ViewModels.TextEntryViewModel;

namespace ChummerDBRazorLibrary.Backend.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddChummerDBServices(this IServiceCollection services)
    {
        services.RegisterViewModels().RegisterModels();
        return services;
    }

    private static IServiceCollection RegisterViewModels(this IServiceCollection services)
    {
        Console.WriteLine("Register View Models");
        services.AddTransient<ISpellsViewModel, SpellsViewModel>();
        
        
        
        //TODO: Remove Example Pages
        services.AddTransient<FetchDataViewModel>();
        services.AddTransient<HexEntryViewModel>();
        services.AddTransient<TextEntryViewModel>();
        services.AddTransient<WeatherForecastService>();

        return services;
    }
    
    private static IServiceCollection RegisterModels(this IServiceCollection services)
    {
        services.AddSingleton<ISpellsModel, SpellsModel>();
        return services;
    }
}