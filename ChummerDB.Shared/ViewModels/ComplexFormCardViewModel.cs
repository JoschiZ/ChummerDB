
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;
using ChummerDB.Shared.xml.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ChummerDB.Shared.ViewModels;

internal sealed partial class ComplexFormCardViewModel: ViewModelBase, IComplexFormCardViewModel
{
    [ObservableProperty] 
    private ComplexForm? _complexForm;

    public string DisplayDuration => ComplexForm != null ? ComplexForm.GetDisplayDuration() : string.Empty;
    public string DisplayFade => ComplexForm != null ? ComplexForm.GetDisplayDrain() : string.Empty;
}