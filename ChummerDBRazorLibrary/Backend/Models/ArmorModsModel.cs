using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public sealed class ArmorModsModel: XmlDataModelBase<ArmorMod>, IArmorModsModel
{
    public ArmorModsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }

    private protected override async Task<List<ArmorMod>> LoadItems()
    {
        var mods = await XmlLoadManager.GetXml<ArmorXmlRecord>();
        Items = mods.Mods.OrderBy(mod => mod.Name).ToList();
        IsLoaded = true;
        return Items;
    }

    public async Task<ArmorMod?> GetArmorMod(string name)
    {
        return (await GetItems()).Find(mod => mod.Name == name);
    }
}