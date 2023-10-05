using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Backend.Models;

public interface IArmorModsModel: IXmlDataModelBase<ArmorMod>
{
    public Task<ArmorMod?> GetItemByName(string name);
}