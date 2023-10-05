using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;

namespace ChummerDB.Blazor.ComponentLibrary.Views;

public interface IGearsViewModel: IViewModelBase
{
    /// <inheritdoc cref="GearsViewModel.items"/>
    System.Collections.ObjectModel.ReadOnlyObservableCollection<Backend.xml.Gear.Gear>? Items { get; set; }
}