using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Halberd : Weapon
{
    public Halberd()
        : base(
            DiceType.D10,
            DamageType.Slashing,
            weight: 6,
            WeaponType.Martial,
            WeaponSubType.Halberd,
            property: new[] { WeaponProperty.Heavy, WeaponProperty.Reach, WeaponProperty.TwoHanded })
    {
    }
}
