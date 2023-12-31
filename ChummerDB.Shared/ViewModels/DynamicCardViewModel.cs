
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Services;
using ChummerDB.Shared.xml.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;


namespace ChummerDB.Shared.ViewModels;

public partial class DynamicCardViewModel<TItem>: ViewModelBase, IDynamicCardViewModel<TItem> where TItem: IHasName
{
    [ObservableProperty] private Type? _cardType;
    [ObservableProperty] private IDictionary<string, object>? _parameters;
    [ObservableProperty] private TItem? _item;
    [ObservableProperty] private string _itemName = string.Empty;

    private readonly ModelProvider _modelProvider;

    public DynamicCardViewModel(ModelProvider modelProvider)
    {
        _modelProvider = modelProvider;
    }

    public override async Task OnParametersSetAsync()
    {
        if (Item is not null)
        {
            SetItemParam(Item);
            return;
        }

        if (!_modelProvider.TryGetNamedXmlDataModel<TItem>(out var model))
        {
            return;
        }
        Item = await model.GetItemByName(ItemName);

        if (Item is not null)
        {
            SetItemParam(Item);
        }
    }

    private void SetItemParam(TItem item)
    {
        if (Parameters is {Count: > 0})
        {
            Parameters.TryAdd<string, object>("Item", item);
        }
        else
        {
            Parameters = new Dictionary<string, object> {{"Item", item}};
        }
    }
}