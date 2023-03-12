using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Greatsword : Weapon
{
    public Greatsword()
        : base(
            DiceType.D6,
            DamageType.Slashing,
            weight: 6,
            WeaponType.Martial,
            WeaponSubType.Greatsword,
            multipleDice: 2,
            property: new[] { WeaponProperty.Heavy, WeaponProperty.TwoHanded })
    {
    }
}
