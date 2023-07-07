using ChummerDBRazorLibrary.Backend.Bases;
using ChummerDBRazorLibrary.Backend.xml;
using ChummerDBRazorLibrary.Backend.xml.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using IHasDamageExtensions = ChummerDBRazorLibrary.Backend.xml.Extensions.IHasDamageExtensions;
using IHasDrainExtensions = ChummerDBRazorLibrary.Backend.xml.Extensions.IHasDrainExtensions;
using IHasDurationExtensions = ChummerDBRazorLibrary.Backend.xml.Extensions.IHasDurationExtensions;
using SpellExtensions = ChummerDBRazorLibrary.Backend.xml.Extensions.SpellExtensions;

namespace ChummerDBRazorLibrary.Components;

public partial class SpellCardViewModel : ViewModelBase, ISpellCardViewModel
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