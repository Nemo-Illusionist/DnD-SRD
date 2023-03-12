using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public abstract class Weapon
{
    protected Weapon(
        DiceType dice,
        DamageType? damageType,
        double weight,
        WeaponType type,
        WeaponSubType subType,
        int multipleDice = 1,
        WeaponRange? range = null,
        IReadOnlyCollection<WeaponProperty>? property = null,
        DiceType? versatileDice = null)
        : this(damageType, weight, type, subType, range, property)
    {
        if (multipleDice <= 0) throw new ArgumentOutOfRangeException(nameof(multipleDice));

        Dice = dice;
        MultipleDice = multipleDice;
        VersatileDice = versatileDice;
    }

    protected Weapon(
        int damage,
        DamageType? damageType,
        double weight,
        WeaponType type,
        WeaponSubType subType,
        WeaponRange? range = null,
        IReadOnlyCollection<WeaponProperty>? property = null)
        : this(damageType, weight, type, subType, range, property)
    {
        if (damage < 0) throw new ArgumentOutOfRangeException(nameof(damage));

        Damage = damage;
    }

    private Weapon(
        DamageType? damageType,
        double weight,
        WeaponType type,
        WeaponSubType subType,
        WeaponRange? range,
        IReadOnlyCollection<WeaponProperty>? property)
    {
        if (weight < 0) throw new ArgumentOutOfRangeException(nameof(weight));

        DamageType = damageType;
        Weight = weight;
        Type = type;
        SubType = subType;
        Range = range;
        Property = property ?? Array.Empty<WeaponProperty>();
    }

    public int? Damage { get; }
    public int MultipleDice { get; }
    public DiceType? Dice { get; }
    public DamageType? DamageType { get; }
    public double Weight { get; }
    public WeaponType Type { get; }
    public WeaponSubType SubType { get; }
    public bool IsRanged => Property.Contains(WeaponProperty.Range);
    public WeaponRange? Range { get; }
    public IReadOnlyCollection<WeaponProperty> Property { get; }
    public DiceType? VersatileDice { get; }
}
