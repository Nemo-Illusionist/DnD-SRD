using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Maul : Weapon
{
    public Maul()
        : base(
            DiceType.D6,
            DamageType.Bludgeoning,
            weight: 10,
            WeaponType.Martial,
            WeaponSubType.Maul,
            multipleDice: 2,
            property: new[] { WeaponProperty.Heavy, WeaponProperty.TwoHanded })
    {
    }
}
