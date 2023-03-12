using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Whip : Weapon
{
    public Whip()
        : base(
            DiceType.D4,
            DamageType.Slashing,
            weight: 3,
            WeaponType.Martial,
            WeaponSubType.Whip,
            property: new[] { WeaponProperty.Finesse, WeaponProperty.Reach })
    {
    }
}
