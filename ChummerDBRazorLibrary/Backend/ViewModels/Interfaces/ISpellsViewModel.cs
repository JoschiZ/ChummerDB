using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.ViewModels.Interfaces;

public interface ISpellsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<Spell>? Spells { get; }
}