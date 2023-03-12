using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class CrossbowHeavy : Weapon
{
    public CrossbowHeavy()
        : base(
            DiceType.D10,
            DamageType.Piercing,
            weight: 18,
            WeaponType.Martial,
            WeaponSubType.CrossbowHeavy,
            range: new WeaponRange(100, 400),
            property: new[]
            {
                WeaponProperty.Ammunition,
                WeaponProperty.Heavy,
                WeaponProperty.Loading,
                WeaponProperty.TwoHanded
            })
    {
    }
}