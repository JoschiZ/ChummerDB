using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Models;

public class ComplexFormsModel: NamedXmlDataModelBase<ComplexForm>, IComplexFormsModel
{
    private protected override async Task<List<ComplexForm>> LoadItems()
    {
        var xml = await XmlLoadManager.GetXml<ComplexFormsXmlRecord>();
        Items = xml.ComplexForms.OrderBy(form => form.Name).ToList();
        IsLoaded = true;
        return await GetItems();
    }

    public ComplexFormsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }
}