using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Models;

public sealed class ArmorModsModel: NamedXmlDataModelBase<ArmorMod>, IArmorModsModel
{
    public ArmorModsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }

    private protected override async Task<List<ArmorMod>> LoadItems()
    {
        var mods = await XmlLoadManager.GetXml<ArmorXmlRecord>();
        Items = mods.Mods.OrderBy(mod => mod.Name).ToList();
        IsLoaded = true;
        return await GetItems();
    }

    private Dictionary<string, ArmorMod?> ByNameCache { get; } = new();
}