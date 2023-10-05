using Microsoft.AspNetCore.Components;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public interface ICard<T>: IComponent
{
    public T? Item { get; set; }
}