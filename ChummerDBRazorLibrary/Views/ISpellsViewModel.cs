using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Views;

public interface ISpellsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<Spell>? Spells { get; }
}