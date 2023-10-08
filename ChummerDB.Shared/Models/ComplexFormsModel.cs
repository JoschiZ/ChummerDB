using ChummerDB.Shared.Bases;
using ChummerDB.Shared.Interfaces;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.Models;

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