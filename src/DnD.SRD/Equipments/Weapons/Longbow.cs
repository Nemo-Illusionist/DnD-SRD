using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Longbow : Weapon
{
    public Longbow()
        : base(
            DiceType.D8,
            DamageType.Piercing,
            weight: 2,
            WeaponType.Martial,
            WeaponSubType.Longbow,
            range: new WeaponRange(150, 600),
            property: new[] { WeaponProperty.Ammunition, WeaponProperty.Heavy, WeaponProperty.TwoHanded })
    {
    }
}