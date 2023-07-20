using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Components;
using ChummerDBRazorLibrary.Views;
using Microsoft.Extensions.DependencyInjection;

namespace ChummerDBRazorLibrary.Backend.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddChummerDBServices(this IServiceCollection services)
    {
        services.AddSingleton<IXmlLoadManager, XmlLoadManager>();
        services.RegisterViewModels().RegisterModels();
        return services;
    }

    private static IServiceCollection RegisterViewModels(this IServiceCollection services)
    {
        // Views
        services.AddTransient<ISpellsViewModel, SpellsViewModel>();
        services.AddTransient<IComplexFormsViewModel, ComplexFormsViewModel>();
        services.AddTransient<IArmorsViewModel, ArmorsViewModel>();
        
        // Components
        services.AddTransient<SpellCardViewModel>();
        services.AddTransient<DisplaySourceViewModel>();
        services.AddTransient<ComplexFormCardViewModel>();
        services.AddTransient<ArmorCardViewModel>();
        services.AddTransient<BonusCardViewModel>();
        return services;
    }
    
    private static IServiceCollection RegisterModels(this IServiceCollection services)
    {
        services.AddSingleton<ISpellsModel, SpellsModel>();
        services.AddSingleton<IBooksModelBase, BooksModelBase>();
        services.AddSingleton<IComplexFormsModel, ComplexFormsModel>();
        services.AddSingleton<IArmorsModel, ArmorsModel>();
        return services;
    }
}