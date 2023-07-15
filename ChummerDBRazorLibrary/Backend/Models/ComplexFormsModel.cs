using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public class ComplexFormsModel: XmlDataModelBase<ComplexForm>, IComplexFormsModel
{
    private protected override async Task<List<ComplexForm>> LoadItems()
    {
        var xml = await XmlLoadManager.GetXml<ComplexFormsXmlRecord>();
        Items = xml.ComplexForms;
        IsLoaded = true;
        return Items;
    }

    public ComplexFormsModel(IXmlLoadManager xmlLoadManager) : base(xmlLoadManager)
    {
    }
}