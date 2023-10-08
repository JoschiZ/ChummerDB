using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml.Gear;

namespace ChummerDB.Shared.ViewModels;

public interface IGearsViewModel: IViewModelBase
{
    /// <inheritdoc cref="GearsViewModel.items"/>
    System.Collections.ObjectModel.ReadOnlyObservableCollection<Gear>? Items { get; set; }
}