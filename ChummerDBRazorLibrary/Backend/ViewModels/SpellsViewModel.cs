using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Bases;

namespace ChummerDBRazorLibrary.Backend.ViewModels;

public partial class SpellsViewModel : ViewModelBase, ISpellsViewModel
{
    private ISpellsModel SpellsModel { get; }
    public ReadOnlyObservableCollection<Spell>? Spells { get; private set; }

    public SpellsViewModel(ISpellsModel spellsModel)
    {
        SpellsModel = spellsModel;
    }

    public override async Task Loaded()
    {
        var spells = await SpellsModel.GetSpells();
        Spells = new ReadOnlyObservableCollection<Spell>(new ObservableCollection<Spell>(spells));
    }
}