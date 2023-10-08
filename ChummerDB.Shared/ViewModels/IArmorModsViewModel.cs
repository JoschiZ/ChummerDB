using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface IArmorModsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<ArmorMod>? Items { get; set; }
}