using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models.Interfaces;
using ChummerDBRazorLibrary.Backend.ViewModels.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Backend.ViewModels;

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
        var spells =(await SpellsModel.GetSpells()).OrderBy(spell => spell.Name);
        
        Spells = new ReadOnlyObservableCollection<Spell>(new ObservableCollection<Spell>(spells));
    }

}