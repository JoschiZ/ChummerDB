using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;

namespace ChummerDB.Shared.ViewModels;

public interface ISpellCardViewModel: IViewModelBase
{
    string DisplayType { get; }
    string DisplayRange { get; }
    string DisplayDamage { get; }
    string DisplayDuration { get; }
    string DisplayDrain { get; }
    Spell? Spell { get; set; }
}