namespace DnD.SRD.Equipments.Armors;

public class ScaleMailArmor : Armor
{
    public ScaleMailArmor()
        : base(
            armorClass: 14,
            ArmorType.Medium,
            weight: 45,
            ArmorSubType.ScaleMail,
            isStealthDisadvantage: true)
    {
    }
}
