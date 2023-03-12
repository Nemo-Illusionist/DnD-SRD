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
        bool isRanged = false,
        WeaponRange? range = null,
        IReadOnlyCollection<WeaponProperty>? property = null,
        DiceType? versatileDice = null)
    {
        if (weight < 0) throw new ArgumentOutOfRangeException(nameof(weight));

        Dice = dice;
        Damage = damage;
        Weight = weight;
        Type = type;
        SubType = subType;
        IsRanged = isRanged;
        Range = range;
        Property = property ?? Array.Empty<WeaponProperty>();
        VersatileDice = versatileDice;
    }


    public DiceType Dice { get; }
    public DamageType Damage { get; }
    public double Weight { get; }
    public WeaponType Type { get; }
    public WeaponSubType SubType { get; }
    public bool IsRanged { get; }
    public WeaponRange? Range { get; }
    public IReadOnlyCollection<WeaponProperty> Property { get; }
    public DiceType? VersatileDice { get; }
}
