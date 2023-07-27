using Microsoft.AspNetCore.Components;

namespace ChummerDBRazorLibrary.Components.Cards;

public interface ICard<T>: IComponent
{
    public T? Item { get; set; }
}