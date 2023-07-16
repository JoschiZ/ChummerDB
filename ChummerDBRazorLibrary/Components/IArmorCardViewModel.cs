using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Components;

public interface IArmorCardViewModel: IViewModelBase
{
    public Armor? Armor { get; set; }
}