using ChummerDBRazorLibrary.Backend.Interfaces;
using ChummerDBRazorLibrary.Backend.Models.Interfaces;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public class ComplexFormsModel: IComplexFormsModel
{
    private List<ComplexForm> ComplexForms { get; set; } = new();
    
    private bool IsLoaded { get; set; }
    
    private IXmlLoadManager XmlLoadManager { get; }

    public ComplexFormsModel(IXmlLoadManager iXmlLoadManager)
    {
        XmlLoadManager = iXmlLoadManager;
    }
    

    public async Task<List<ComplexForm>> GetComplexForms()
    {
        if (IsLoaded)
        {
            return ComplexForms;
        }
        
        return await LoadComplexForms();
    }

    private async Task<List<ComplexForm>> LoadComplexForms()
    {
        var xml = await XmlLoadManager.GetXml<ComplexFormsXmlRecord>();
        ComplexForms = xml.ComplexForms;
        IsLoaded = true;
        return ComplexForms;
    }
}