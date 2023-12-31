
using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;
using ChummerDB.Shared.xml.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
namespace ChummerDB.Shared.ViewModels;



internal sealed partial class SpellCardViewModel : ViewModelBase, ISpellCardViewModel
{
    [ObservableProperty] 
    private Spell? _spell;
    public string DisplayType => Spell != null ? Spell.GetDisplayType() : string.Empty;
    public string DisplayRange => Spell != null ? Spell.GetDisplayRange() : string.Empty;
    public string DisplayDamage => Spell != null ? displayFullDamage() : string.Empty;
    public string DisplayDuration => Spell != null ? Spell.GetDisplayDuration() : string.Empty;
    public string DisplayDrain => Spell != null ? Spell.GetDisplayDrain() : string.Empty;
    private string displayFullDamage()
    {
        if (Spell is null)
        {
            return string.Empty;
        }

        if (Spell.Damage == "0")
        {
            return string.Empty;
        }

        const string fullDamage = "[Force]";
        return $"{fullDamage} {Spell.GetDisplayDamage()}";
    }
}