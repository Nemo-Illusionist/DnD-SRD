namespace DnD.SRD.Equipments.Armors;

public class StuddedLeatherArmor : Armor
{
    public StuddedLeatherArmor() : base(
        armorClass: 12,
        ArmorType.Light,
        weight: 13,
        ArmorSubType.StuddedLeather,
        isStealthDisadvantage: false)
    {
    }
}