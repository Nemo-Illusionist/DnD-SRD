namespace DnD.SRD.Equipments.Armors;

public class HalfPlateArmor : Armor
{
    public HalfPlateArmor()
        : base(
            armorClass: 15,
            ArmorType.Medium,
            weight: 40,
            ArmorSubType.HalfPlate,
            isStealthDisadvantage: true)
    {
    }
}
