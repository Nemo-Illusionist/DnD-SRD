namespace DnD.SRD.Equipments.Armors;

public class SplintArmor : Armor
{
    public SplintArmor() : base(
        armorClass: 17,
        ArmorType.Heavy,
        weight: 60,
        ArmorSubType.Splint,
        strength: 15,
        isStealthDisadvantage: true)
    {
    }
}