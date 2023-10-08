using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface IComplexFormCardViewModel: IViewModelBase
{
    string DisplayDuration { get; }
    string DisplayFade { get; }

    /// <inheritdoc cref="ComplexFormCardViewModel._complexForm"/>
    ComplexForm? ComplexForm { get; set; }
}