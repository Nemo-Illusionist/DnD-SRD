using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Dart : Weapon
{
    public Dart()
        : base(
            DiceType.D4,
            DamageType.Piercing,
            weight: 0.25,
            WeaponType.Simple,
            WeaponSubType.Dart,
            range: new WeaponRange(20, 60),
            property: new[] { WeaponProperty.Finesse, WeaponProperty.Thrown, WeaponProperty.Range })
    {
    }
}
