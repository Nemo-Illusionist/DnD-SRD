namespace DnD.SRD.Equipments.Armors;

public class PlateArmor : Armor
{
    public PlateArmor() : base(
        armorClass: 18,
        ArmorType.Heavy,
        weight: 65,
        ArmorSubType.Plate,
        strength: 15,
        isStealthDisadvantage: true)
    {
    }
}