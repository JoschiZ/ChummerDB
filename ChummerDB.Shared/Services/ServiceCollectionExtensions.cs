using ChummerDB.Shared.Interfaces;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.ViewModels;
using ChummerDB.Shared.xml;
using ChummerDB.Shared.xml.Gear;

namespace ChummerDB.Shared.Services;

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