using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml.Interfaces;

namespace ChummerDB.Shared.ViewModels;

public interface IDynamicCardViewModel<TItem>: IViewModelBase where TItem : IHasName
{
    Type? CardType { get; set; }
    IDictionary<string, object>? Parameters { get; set; }
    TItem? Item { get; set; }
    string ItemName { get; set; }
}