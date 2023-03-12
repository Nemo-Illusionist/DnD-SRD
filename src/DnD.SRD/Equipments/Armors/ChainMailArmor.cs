namespace DnD.SRD.Equipments.Armors;

public class ChainMailArmor : Armor
{
    public ChainMailArmor() : base(
        armorClass: 16,
        ArmorType.Heavy,
        weight: 55,
        ArmorSubType.ChainMail,
        strength: 13,
        isStealthDisadvantage: true)
    {
    }
}