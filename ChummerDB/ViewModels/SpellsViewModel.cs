using ChummerDB.Models;

namespace ChummerDB.ViewModels;

internal sealed class SpellsViewModel: ISpellsViewModel
{
    private ISpellsModel SpellsModel { get; init; }
    
    public SpellsViewModel(ISpellsModel iSpellsModel)
    {
        Console.WriteLine("SpellsViewModel Constructor");
        SpellsModel = iSpellsModel;
    }

    public string Test { get; set; } = "Test";
}