using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Views;

public interface IArmorModsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<ArmorMod>? Items { get; set; }
}