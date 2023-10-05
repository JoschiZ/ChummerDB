using ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;
using ChummerDB.Blazor.ComponentLibrary.Backend.Models;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Gear;
using ChummerDB.Blazor.ComponentLibrary.Components;
using ChummerDB.Blazor.ComponentLibrary.Components.Cards;
using ChummerDB.Blazor.ComponentLibrary.Views;
using Microsoft.Extensions.DependencyInjection;


namespace ChummerDB.Blazor.ComponentLibrary.Backend.Services;

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
        services.AddTransient<IGearsViewModel, GearsViewModel>();
        
        // Components
        services.AddTransient<ISpellCardViewModel, SpellCardViewModel>();
        services.AddTransient<IDisplaySourceViewModel, DisplaySourceViewModel>();
        services.AddTransient<IComplexFormCardViewModel, ComplexFormCardViewModel>();
        services.AddTransient<IArmorCardViewModel, ArmorCardViewModel>();
        services.AddTransient<IBonusCardViewModel, BonusCardViewModel>();
        services.AddTransient<IArmorModCardViewModel, ArmorModCardViewModel>();
        services.AddTransient<TestViewModel>();

        services.RegisterDynamicCards();
        return services;
    }

    private static IServiceCollection RegisterDynamicCards(this IServiceCollection services)
    {
        services.AddTransient(typeof(IDynamicCardViewModel<>) , typeof(DynamicCardViewModel<>));
        services.AddTransient<IDialogCardViewModel, DialogCardViewModel>();
        

        return services;
    }
    
    private static IServiceCollection RegisterModels(this IServiceCollection services)
    {
        services.AddSingleton<ISpellsModel, SpellsModel>();
        ModelProvider.RegisterModel<Spell, ISpellsModel>();
        
        services.AddSingleton<IBooksModel, BooksModel>();
        ModelProvider.RegisterModel<Book, IBooksModel>();
        
        services.AddSingleton<IComplexFormsModel, ComplexFormsModel>();
        ModelProvider.RegisterModel<ComplexForm, IComplexFormsModel>();
        
        services.AddSingleton<IArmorsModel, ArmorsModel>();
        ModelProvider.RegisterModel<Armor, IArmorsModel>();
        
        services.AddSingleton<IArmorModsModel, ArmorModsModel>();
        ModelProvider.RegisterModel<ArmorMod, IArmorModsModel>();
        
        services.AddSingleton<GearsModel>();
        ModelProvider.RegisterModel<Gear, GearsModel>();
        
        return services;
    }
}