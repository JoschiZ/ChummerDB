using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Models;

public sealed class ArmorsModel : NamedXmlDataModelBase<Armor>, IArmorsModel
{
    public ArmorsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }

    private protected override async Task<List<Armor>> LoadItems()
    {
        var armors = await XmlLoadManager.GetXml<ArmorXmlRecord>();
        Items = armors.Armors.OrderBy(armor => armor.Name).ToList();
        IsLoaded = true;
        return await GetItems();
    }
}