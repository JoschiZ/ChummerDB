using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;

namespace ChummerDB.Blazor.ComponentLibrary.Components;

public interface ISpellCardViewModel: IViewModelBase
{
    string DisplayType { get; }
    string DisplayRange { get; }
    string DisplayDamage { get; }
    string DisplayDuration { get; }
    string DisplayDrain { get; }
    Spell? Spell { get; set; }
}