using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Models.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;
public class SpellsModel : ISpellsModel
{
    public List<Spell> Spells { get; set; } = new();
    
    private bool IsLoaded { get; set; }
    
    private IXmlLoadManager XmlLoadManager { get; }

    public SpellsModel(IXmlLoadManager iXmlLoadManager)
    {
        XmlLoadManager = iXmlLoadManager;
    }
    

    public async Task<List<Spell>> GetSpells()
    {
        if (IsLoaded)
        {
            return Spells;
        }
        
        return await LoadSpells();
    }

    private async Task<List<Spell>> LoadSpells()
    {
        var xml = await XmlLoadManager.GetXml<SpellsXmlRecord>();
        Spells = xml.Spells;
        IsLoaded = true;
        return Spells;
    }
    
}
