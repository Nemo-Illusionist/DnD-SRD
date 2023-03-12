using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Dagger : Weapon
{
    public Dagger()
        : base(
            DiceType.D4,
            DamageType.Piercing,
            weight: 1,
            type: WeaponType.Simple,
            subType: WeaponSubType.Dagger,
            range: new WeaponRange(20, 60),
            property: new[] { WeaponProperty.Finesse, WeaponProperty.Light, WeaponProperty.Thrown })
    {
    }
}