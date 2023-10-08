using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface IArmorCardViewModel: IViewModelBase
{
    public Armor? Armor { get; set; }
}