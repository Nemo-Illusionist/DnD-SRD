using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Trident : Weapon
{
    public Trident()
        : base(
            DiceType.D6,
            DamageType.Piercing,
            weight: 4,
            WeaponType.Martial,
            WeaponSubType.Trident,
            range: new WeaponRange(20, 60),
            versatileDice: DiceType.D8,
            property: new[] { WeaponProperty.Thrown, WeaponProperty.Versatile })
    {
    }
}
