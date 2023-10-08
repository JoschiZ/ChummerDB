using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.Models;

public interface IArmorModsModel: IXmlDataModelBase<ArmorMod>
{
    public Task<ArmorMod?> GetItemByName(string name);
}