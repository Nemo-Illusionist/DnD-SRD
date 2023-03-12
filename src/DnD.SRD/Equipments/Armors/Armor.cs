namespace DnD.SRD.Equipments.Armors;

public abstract class Armor
{
    protected Armor(
        int armorClass,
        ArmorType type,
        double weight,
        ArmorSubType subType = ArmorSubType.None,
        int strength = 0,
        bool isStealthDisadvantage = false)
    {
        if (armorClass <= 0) throw new ArgumentOutOfRangeException(nameof(armorClass));
        if (weight <= 0) throw new ArgumentOutOfRangeException(nameof(weight));
        if (strength <= 0) throw new ArgumentOutOfRangeException(nameof(strength));

        ArmorClass = armorClass;
        Type = type;
        Weight = weight;
        SubType = subType;
        Strength = strength;
        IsStealthDisadvantage = isStealthDisadvantage;
    }

    public int ArmorClass { get; }
    public ArmorType Type { get; }
    public double Weight { get; }
    public ArmorSubType SubType { get; }
    public int Strength { get; }
    public bool IsStealthDisadvantage { get; }
}
