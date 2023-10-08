using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Interfaces;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.Models;

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