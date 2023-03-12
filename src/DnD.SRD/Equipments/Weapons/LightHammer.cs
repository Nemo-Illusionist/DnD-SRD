using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class LightHammer : Weapon
{
    public LightHammer()
        : base(
            DiceType.D4,
            DamageType.Bludgeoning,
            weight: 2,
            WeaponType.Simple,
            WeaponSubType.LightHammer,
            range: new WeaponRange(20, 60),
            property: new[] { WeaponProperty.Light, WeaponProperty.Thrown })
    {
    }
}