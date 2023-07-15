using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public class ArmorsModel : XmlDataModelBase<Armor>, IArmorsModel
{
    public ArmorsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }

    private protected override async Task<List<Armor>> LoadItems()
    {
        var armors = await XmlLoadManager.GetXml<ArmorXmlRecord>();
        Items = armors.Armors.OrderBy(armor => armor.Name).ToList();
        IsLoaded = true;
        return Items;
    }
}