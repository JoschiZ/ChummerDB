using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;
public class SpellsModel : XmlDataModelBase<Spell>, ISpellsModel
{
    private protected override async Task<List<Spell>> LoadItems()
    {
        var xml = await XmlLoadManager.GetXml<SpellsXmlRecord>();
        Items = xml.Spells;
        IsLoaded = true;
        return Items;
    }

    public SpellsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }
}
