namespace DnD.SRD.Equipments.Armors;

public class PaddedArmor : Armor
{
    public PaddedArmor()
        : base(
            armorClass: 11,
            ArmorType.Light,
            weight: 8,
            ArmorSubType.Padded,
            isStealthDisadvantage: true)
    {
    }
}
