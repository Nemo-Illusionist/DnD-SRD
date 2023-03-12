using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Handaxe : Weapon
{
    public Handaxe()
        : base(
            DiceType.D6,
            DamageType.Slashing,
            weight: 2,
            WeaponType.Simple,
            WeaponSubType.Handaxe,
            range: new WeaponRange(20, 60),
            property: new[] { WeaponProperty.Light, WeaponProperty.Thrown })
    {
    }
}
