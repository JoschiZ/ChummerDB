using System.Collections.ObjectModel;
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface IComplexFormsViewModel: IViewModelBase
{
    public ReadOnlyObservableCollection<ComplexForm>? ComplexForms { get; }
}