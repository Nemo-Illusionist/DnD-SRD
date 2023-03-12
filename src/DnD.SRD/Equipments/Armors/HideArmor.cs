namespace DnD.SRD.Equipments.Armors;

public class HideArmor : Armor
{
    public HideArmor() : base(
        armorClass: 12,
        ArmorType.Medium,
        weight: 12,
        ArmorSubType.Hide,
        isStealthDisadvantage: false)
    {
    }
}