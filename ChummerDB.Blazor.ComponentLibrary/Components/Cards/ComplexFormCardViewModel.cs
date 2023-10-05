using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Extensions;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using ChummerDB.Blazor.ComponentLibrary.Components.Cards;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ChummerDB.Blazor.ComponentLibrary.Components;

public partial class ComplexFormCardViewModel: ViewModelBase, IComplexFormCardViewModel
{
    [ObservableProperty] 
    private ComplexForm? _complexForm;

    public string DisplayDuration => ComplexForm != null ? ComplexForm.GetDisplayDuration() : string.Empty;
    public string DisplayFade => ComplexForm != null ? ComplexForm.GetDisplayDrain() : string.Empty;
}