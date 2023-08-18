using System.Xml.Serialization;

namespace ChummerDBRazorLibrary.Backend.xml.Bonus;

[XmlRoot("matrixinitiativedice")]
public class MatrixInitiativeDiceBonus: BaseBonus
{
    public override string DisplayString => DiceBonus.ToString();
    
    [XmlText]
    public int DiceBonus { get; set; }
}