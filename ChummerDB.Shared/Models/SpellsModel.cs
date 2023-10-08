using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Interfaces;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.Models;
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
