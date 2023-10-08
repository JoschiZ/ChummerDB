using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Shared.ViewModels;

internal partial class SpellsViewModel : ViewModelBase, ISpellsViewModel
{
    private ISpellsModel SpellsModel { get; }

    [ObservableProperty] 
    private ReadOnlyObservableCollection<Spell>? _spells;

    public SpellsViewModel(ISpellsModel spellsModel)
    {
        SpellsModel = spellsModel;
    }

    public override async Task Loaded()
    {
        var spells = await SpellsModel.GetItems();
        
        Spells = new ReadOnlyObservableCollection<Spell>(new ObservableCollection<Spell>(spells));
    }

}