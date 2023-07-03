using System.Collections.ObjectModel;

namespace ChummerDBRazorLibrary.Backend.Interfaces;

public interface ISpellsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<Spell>? Spells { get; }
}