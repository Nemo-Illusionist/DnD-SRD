namespace DnD.SRD.Equipments.Armors;

public class RingMailArmor : Armor
{
    public RingMailArmor()
        : base(
            armorClass: 14,
            ArmorType.Heavy,
            weight: 40,
            ArmorSubType.RingMail,
            isStealthDisadvantage: true)
    {
    }
}
