namespace DnD.SRD.Equipments.Armors;

public class LeatherArmor : Armor
{
    public LeatherArmor() : base(
        armorClass: 11,
        ArmorType.Light,
        weight: 10,
        ArmorSubType.Leather,
        isStealthDisadvantage: false)
    {
    }
}