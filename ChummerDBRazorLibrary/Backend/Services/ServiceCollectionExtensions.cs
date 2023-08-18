using System.Diagnostics.CodeAnalysis;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Backend.xml.Bonus;
using ChummerDBRazorLibrary.Backend.xml.Gear;
using ChummerDBRazorLibrary.Components;
using ChummerDBRazorLibrary.Components.Cards;
using ChummerDBRazorLibrary.Views;
using Microsoft.Extensions.DependencyInjection;


namespace ChummerDBRazorLibrary.Backend.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddChummerDBServices(this IServiceCollection services)
    {
        services.AddSingleton<IXmlLoadManager, XmlLoadManager>();
        services.AddSingleton<ModelProvider>();
        services.RegisterViewModels().RegisterModels();
        return services;
    }

    private static IServiceCollection RegisterViewModels(this IServiceCollection services)
    {
        // Views
        services.AddTransient<ISpellsViewModel, SpellsViewModel>();
        services.AddTransient<IComplexFormsViewModel, ComplexFormsViewModel>();
        services.AddTransient<IArmorsViewModel, ArmorsViewModel>();
        services.AddTransient<IArmorModsViewModel, ArmorModsViewModel>();
        services.AddTransient<GearsViewModel>();
        
        // Components
        services.AddTransient<SpellCardViewModel>();
        services.AddTransient<DisplaySourceViewModel>();
        services.AddTransient<ComplexFormCardViewModel>();
        services.AddTransient<ArmorCardViewModel>();
        services.AddTransient<BonusCardViewModel>();
        services.AddTransient<ArmorCardViewModel>();
        services.AddTransient<ArmorModCardViewModel>();
        services.AddTransient<TestViewModel>();

        services.RegisterDynamicCards();
        return services;
    }

    private static IServiceCollection RegisterDynamicCards(this IServiceCollection services)
    {
        services.AddTransient(typeof(DynamicCardViewModel<>));
        services.AddTransient<DialogCardViewModel>();
        

        return services;
    }
    
    private static IServiceCollection RegisterModels(this IServiceCollection services)
    {
        services.AddSingleton<ISpellsModel, SpellsModel>();
        ModelProvider.RegisterModel<Spell, ISpellsModel>();
        
        services.AddSingleton<IBooksModel, BooksModel>();
        ModelProvider.RegisterModel<Book, IBooksModel>();
        
        services.AddSingleton<IComplexFormsModel, ComplexFormsModel>();
        services.AddSingleton<IArmorsModel, ArmorsModel>();
        
        services.AddSingleton<IArmorModsModel, ArmorModsModel>();
        ModelProvider.RegisterModel<ArmorMod, IArmorModsModel>();
        
        services.AddSingleton<GearsModel>();
        ModelProvider.RegisterModel<Gear, GearsModel>();
        
        return services;
    }
}