namespace DnD.SRD.Equipments.Armors;

public class BreastplateArmor : Armor
{
    public BreastplateArmor()
        : base(
            armorClass: 14,
            ArmorType.Medium,
            weight: 20,
            ArmorSubType.Breastplate,
            isStealthDisadvantage: false)
    {
    }
}
