using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models.Interfaces;
using ChummerDBRazorLibrary.Backend.ViewModels.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Backend.ViewModels;

public partial class ComplexFormsViewModel: ViewModelBase, IComplexFormsViewModel
{
    private IComplexFormsModel ComplexFormsModel { get; }

    [ObservableProperty] 
    private ReadOnlyObservableCollection<ComplexForm>? _complexForms;

    public ComplexFormsViewModel(IComplexFormsModel complexFormsModel)
    {
        ComplexFormsModel = complexFormsModel;
    }
    
    public override async Task Loaded()
    {
        var spells =(await ComplexFormsModel.GetComplexForms()).OrderBy(spell => spell.Name);
        
        ComplexForms = new ReadOnlyObservableCollection<ComplexForm>(new ObservableCollection<ComplexForm>(spells));
    }
}