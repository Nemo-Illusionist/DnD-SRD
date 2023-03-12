using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Javelin : Weapon
{
    public Javelin()
        : base(
            DiceType.D6,
            DamageType.Piercing,
            weight: 2,
            WeaponType.Simple,
            WeaponSubType.Javelin,
            range: new WeaponRange(30, 120),
            property: new[] { WeaponProperty.Thrown })
    {
    }
}
