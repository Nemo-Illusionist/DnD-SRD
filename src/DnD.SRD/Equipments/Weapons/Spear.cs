using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Spear : Weapon
{
    public Spear()
        : base(
            DiceType.D6,
            DamageType.Piercing,
            weight: 3,
            WeaponType.Simple,
            WeaponSubType.Spear,
            range: new WeaponRange(20, 60),
            versatileDice: DiceType.D8,
            property: new[] { WeaponProperty.Thrown, WeaponProperty.Versatile })
    {
    }
}