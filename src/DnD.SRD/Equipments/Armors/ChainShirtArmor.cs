namespace DnD.SRD.Equipments.Armors;

public class ChainShirtArmor : Armor
{
    public ChainShirtArmor() : base(
        armorClass: 13,
        ArmorType.Medium,
        weight: 20,
        ArmorSubType.ChainShirt,
        isStealthDisadvantage: false)
    {
    }
}