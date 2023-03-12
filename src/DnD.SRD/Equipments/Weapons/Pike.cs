using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Pike : Weapon
{
    public Pike()
        : base(
            DiceType.D10,
            DamageType.Piercing,
            weight: 18,
            WeaponType.Martial,
            WeaponSubType.Pike,
            property: new[] { WeaponProperty.Heavy, WeaponProperty.Reach, WeaponProperty.TwoHanded })
    {
    }
}
