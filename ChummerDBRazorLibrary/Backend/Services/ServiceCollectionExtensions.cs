using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Components;
using ChummerDBRazorLibrary.Views;
using Microsoft.Extensions.DependencyInjection;

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
        // Views
        services.AddTransient<ISpellsViewModel, SpellsViewModel>();
        services.AddTransient<IComplexFormsViewModel, ComplexFormsViewModel>();
        
        // Components
        services.AddTransient<SpellCardViewModel>();
        services.AddTransient<DisplaySourceViewModel>();
        services.AddTransient<ComplexFormCardViewModel>();
        return services;
    }
    
    private static IServiceCollection RegisterModels(this IServiceCollection services)
    {
        services.AddSingleton<ISpellsModel, SpellsModel>();
        services.AddSingleton<IBooksModel, BooksModel>();
        services.AddSingleton<IComplexFormsModel, ComplexFormsModel>();
        return services;
    }
}