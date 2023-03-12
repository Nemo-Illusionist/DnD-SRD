using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Battleaxe : Weapon
{
    public Battleaxe()
        : base(
            DiceType.D8,
            DamageType.Slashing,
            weight: 4,
            WeaponType.Martial,
            WeaponSubType.Battleaxe,
            property: new[] { WeaponProperty.Versatile }, versatileDice: DiceType.D10)
    {
    }
}
