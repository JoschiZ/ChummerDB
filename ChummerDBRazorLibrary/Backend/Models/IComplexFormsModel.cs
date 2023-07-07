using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public interface IComplexFormsModel
{
    public Task<List<ComplexForm>> GetComplexForms();
}