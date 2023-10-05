using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Components.Cards;

public interface IComplexFormCardViewModel: IViewModelBase
{
    string DisplayDuration { get; }
    string DisplayFade { get; }

    /// <inheritdoc cref="ComplexFormCardViewModel._complexForm"/>
    ComplexForm? ComplexForm { get; set; }
}