using System.Xml.Serialization;

namespace ChummerDB.Shared.xml.Bonus;

[XmlRoot("matrixinitiativedice")]
public class MatrixInitiativeDiceBonus: BaseBonus
{
    public override string DisplayString => DiceBonus.ToString();
    
    [XmlText]
    public int DiceBonus { get; set; }
}