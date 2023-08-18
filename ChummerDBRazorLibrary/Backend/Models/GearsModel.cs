using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml.Gear;
using Microsoft.Extensions.Logging;

namespace ChummerDBRazorLibrary.Backend.Models;

public class GearsModel: NamedXmlDataModelBase<Gear>
{
    private ILogger<GearsModel> _logger;
    public GearsModel(IXmlLoadManager xmlLoadManager, ILogger<GearsModel> logger) : base(xmlLoadManager)
    {
        _logger = logger;
    }

    private protected override async Task<List<Gear>> LoadItems()
    {
        var xmlRecord = await XmlLoadManager.GetXml<GearsXmlRecord>();
        
        Items = xmlRecord.AllGears.Where(gear => 
            gear is not Ammunition 
            && gear is not ElectronicGear).ToList();
        
        IsLoaded = true;
        return await GetItems();
    }
}