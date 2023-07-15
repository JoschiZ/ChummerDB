using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Models;

namespace ChummerDBRazorLibrary.Views;

public partial class ArmorsViewModel: ViewModelBase, IArmorsViewModel
{
    public ArmorsViewModel(IArmorsModel armorsModel)
    {
        ArmorsModel = armorsModel;
    }

    private IArmorsModel ArmorsModel { get; }
}