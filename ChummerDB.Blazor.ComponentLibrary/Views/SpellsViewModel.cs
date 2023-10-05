using System.Collections.ObjectModel;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Models;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Views;

public partial class SpellsViewModel : ViewModelBase, ISpellsViewModel
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