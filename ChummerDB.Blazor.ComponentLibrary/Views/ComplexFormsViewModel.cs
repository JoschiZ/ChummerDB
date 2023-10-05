using System.Collections.ObjectModel;
using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Models;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Blazor.ComponentLibrary.Views;

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
        var spells = await ComplexFormsModel.GetItems();
        
        ComplexForms = new ReadOnlyObservableCollection<ComplexForm>(new ObservableCollection<ComplexForm>(spells));
    }
}