using System.Diagnostics.CodeAnalysis;
using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml.Interfaces;

namespace ChummerDBRazorLibrary.Backend.Services;

public class ModelProvider
{
    private readonly IServiceProvider _serviceProvider;
    
    private static Dictionary<Type, Type> Models { get; } = new();

    public ModelProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public static void RegisterModel<TItem, TModel>() where TModel: IXmlDataModelBase<TItem>
    {
        Models.TryAdd(typeof(TItem), typeof(TModel));
    }

    public bool TryGetNamedXmlDataModel<TItem>([NotNullWhen(returnValue: true)] out INamedXmlDataModel<TItem>? outModel)
        where TItem : IHasName
    {
        outModel = null;
        
        if (!Models.TryGetValue(typeof(TItem), out var tModel))
        {
            return false;
        }

        outModel = _serviceProvider.GetService(tModel) as INamedXmlDataModel<TItem>;

        return outModel is not null;
    }
}
