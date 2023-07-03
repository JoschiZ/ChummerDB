namespace ChummerDBRazorLibrary.Backend.Interfaces;

public interface ISpellsModel
{
    public Task<IList<Spell>> GetSpells();
}