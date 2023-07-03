using ChummerDBRazorLibrary.Backend;

namespace ChummerDBRazorLibrary.Interfaces;

public interface ISpellsModel
{
    public Task<IList<Spell>> GetSpells();
}