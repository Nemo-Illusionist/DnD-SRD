using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public abstract class Weapon
{
    protected Weapon(
        DiceType dice,
        DamageType damage,
        double weight,
        WeaponType type,
        WeaponSubType subType,
        int multipleDice = 1,
        WeaponRange? range = null,
        IReadOnlyCollection<WeaponProperty>? property = null,
        DiceType? versatileDice = null)
    {
        if (weight < 0) throw new ArgumentOutOfRangeException(nameof(weight));
        if (multipleDice <= 0) throw new ArgumentOutOfRangeException(nameof(multipleDice));

        Dice = dice;
        Damage = damage;
        Weight = weight;
        Type = type;
        SubType = subType;
        MultipleDice = multipleDice;
        Range = range;
        Property = property ?? Array.Empty<WeaponProperty>();
        VersatileDice = versatileDice;
    }


    public int MultipleDice { get; }
    public DiceType Dice { get; }
    public DamageType Damage { get; }
    public double Weight { get; }
    public WeaponType Type { get; }
    public WeaponSubType SubType { get; }
    public bool IsRanged => Property.Contains(WeaponProperty.Range);
    public WeaponRange? Range { get; }
    public IReadOnlyCollection<WeaponProperty> Property { get; }
    public DiceType? VersatileDice { get; }
}
