using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;
using ChummerDBRazorLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.Views;

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