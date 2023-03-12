using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Sling : Weapon
{
    public Sling()
        : base(
            DiceType.D4,
            DamageType.Bludgeoning,
            weight: 0,
            WeaponType.Simple,
            WeaponSubType.Sling,
            isRanged: true,
            range: new WeaponRange(30, 120),
            property: new[] { WeaponProperty.Ammunition })
    {
    }
}