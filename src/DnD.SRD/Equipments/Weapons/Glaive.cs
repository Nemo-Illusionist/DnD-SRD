using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Glaive : Weapon
{
    public Glaive()
        : base(
            DiceType.D10,
            DamageType.Slashing,
            weight: 6,
            WeaponType.Martial,
            WeaponSubType.Glaive,
            property: new[] { WeaponProperty.Heavy, WeaponProperty.Reach, WeaponProperty.TwoHanded })
    {
    }
}
