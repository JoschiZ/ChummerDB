using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public interface ISpellsModel
{
    public Task<List<Spell>> GetSpells();
}