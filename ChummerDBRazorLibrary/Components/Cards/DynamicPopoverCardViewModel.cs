using ChummerDBRazorLibrary.Backend.Bases;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChummerDBRazorLibrary.Components.Cards;

public partial class DynamicPopoverCardViewModel<TItem, TModel>: ViewModelBase
{
    [ObservableProperty] 
    private bool _isOpen;

    [ObservableProperty] private Type? _type;
    [ObservableProperty] private IDictionary<string, object>? _parameters;
    [ObservableProperty] private TItem? _item;
    [ObservableProperty] private string? _itemName;
    private TModel _model;

    public DynamicPopoverCardViewModel(TModel model)
    {
        _model = model;
    }

    [RelayCommand]
    private void Toggle()
    {
        IsOpen = !IsOpen;
    }

    public override void OnParametersSet()
    {
        if (Item is null)
        {
            return;
        }
        
        if (Parameters is {Count: > 0})
        {
            Parameters.TryAdd("Item", Item);
        }
        else
        {
            Parameters = new Dictionary<string, object> {{"Item", Item}};
        }
    }
}