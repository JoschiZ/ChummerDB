using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Backend.xml.Extensions;
using ChummerDBRazorLibrary.Components.ViewModels.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Components.ViewModels;

public partial class ComplexFormCardViewModel: ViewModelBase, IComplexFormCardViewModel
{
    [ObservableProperty] 
    private ComplexForm? _complexForm;

    public string DisplayDuration => ComplexForm != null ? ComplexForm.GetDisplayDuration() : string.Empty;
    public string DisplayFade => ComplexForm != null ? ComplexForm.GetDisplayDrain() : string.Empty;
}