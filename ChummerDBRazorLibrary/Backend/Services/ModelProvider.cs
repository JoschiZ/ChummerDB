using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.Services;

public class ModelProvider
{
    private readonly IArmorModsModel _armorModsModel;
    private readonly IArmorsModel _armorsModel;
    private readonly IBooksModel _booksModel;
    private readonly IComplexFormsModel _complexFormsModel;
    private readonly ISpellsModel _spellsModel;

    public ModelProvider(IArmorModsModel armorModsModel, IArmorsModel armorsModel, IBooksModel booksModel, IComplexFormsModel complexFormsModel, ISpellsModel spellsModel)
    {
        _armorModsModel = armorModsModel;
        _armorsModel = armorsModel;
        _booksModel = booksModel;
        _complexFormsModel = complexFormsModel;
        _spellsModel = spellsModel;
    }

    public INamedXmlDataModel<T> GetNamedModel<T>() where T: IHasName
    {
        return typeof(T) switch
        {
            { } type when type == typeof(ArmorMod) => (INamedXmlDataModel<T>) _armorModsModel,
            { } type when type == typeof(Armor) => (INamedXmlDataModel<T>) _armorsModel,
            { } type when type == typeof(Book) => (INamedXmlDataModel<T>) _booksModel,
            { } type when type == typeof(ComplexForm) => (INamedXmlDataModel<T>) _complexFormsModel,
            { } type when type == typeof(Spell) => (INamedXmlDataModel<T>) _spellsModel,
            _ => throw new ArgumentException($"No model corresponds to the type {typeof(T)}")
        };
    }
}