using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Interfaces;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public interface IDynamicCardViewModel<TItem>: IViewModelBase where TItem : IHasName
{
    Type? CardType { get; set; }
    IDictionary<string, object>? Parameters { get; set; }
    TItem? Item { get; set; }
    string ItemName { get; set; }
}