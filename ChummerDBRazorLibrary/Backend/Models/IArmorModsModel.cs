using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;

namespace ChummerDBRazorLibrary.Backend.Models;

public interface IArmorModsModel: IXmlDataModelBase<ArmorMod>
{
    public Task<ArmorMod?> GetArmorMod(string name);
}