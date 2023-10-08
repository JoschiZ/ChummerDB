using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Models;
using ChummerDB.Shared.xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDB.Shared.ViewModels;

internal sealed partial class ComplexFormsViewModel: ViewModelBase, IComplexFormsViewModel
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