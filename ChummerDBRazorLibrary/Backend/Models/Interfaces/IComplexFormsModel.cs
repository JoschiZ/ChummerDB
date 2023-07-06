using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models.Interfaces;

public interface IComplexFormsModel
{
    public Task<List<ComplexForm>> GetComplexForms();
}