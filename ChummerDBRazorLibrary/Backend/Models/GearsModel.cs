using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Backend.xml.Gear;

namespace ChummerDBRazorLibrary.Backend.Models;

public class GearsModel: NamedXmlDataModelBase<Gear>
{
    public GearsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }

    private protected override async Task<List<Gear>> LoadItems()
    {
        var xmlRecord = await XmlLoadManager.GetXml<GearsXmlRecord>();
        Items = xmlRecord.Gears;
        IsLoaded = true;
        return await GetItems();
    }
}