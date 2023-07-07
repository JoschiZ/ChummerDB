using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Views;

public interface IComplexFormsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<ComplexForm>? ComplexForms { get; }
}