using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Shortbow : Weapon
{
    public Shortbow()
        : base(
            DiceType.D6,
            DamageType.Piercing,
            weight: 2,
            WeaponType.Simple,
            WeaponSubType.Shortbow,
            range: new WeaponRange(80, 320),
            property: new[] { WeaponProperty.Ammunition, WeaponProperty.TwoHanded, WeaponProperty.Range })
    {
    }
}
