using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;
public class SpellsModel : NamedXmlDataModelBase<Spell>, ISpellsModel
{
    private protected override async Task<List<Spell>> LoadItems()
    {
        var xml = await XmlLoadManager.GetXml<SpellsXmlRecord>();
        Items = xml.Spells.OrderBy(spell => spell.Name).ToList();
        IsLoaded = true;
        return await GetItems();
    }

    public SpellsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }
}
