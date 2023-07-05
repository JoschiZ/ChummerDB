using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models.Interfaces;

public interface ISpellsModel
{
    public Task<List<Spell>> GetSpells();
}