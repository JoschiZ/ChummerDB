namespace ChummerDB.Models;


public interface ISpellsModel
{
    
}

internal sealed class SpellsModel: ISpellsModel
{
    public SpellsModel()
    {
        Console.WriteLine("SpellsModel Constructor");
    }
}