using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class CrossbowLight : Weapon
{
    public CrossbowLight()
        : base(
            DiceType.D8,
            DamageType.Piercing,
            weight: 5,
            WeaponType.Simple,
            WeaponSubType.CrossbowLight,
            range: new WeaponRange(80, 320),
            property: new[]
            {
                WeaponProperty.Ammunition,
                WeaponProperty.Loading,
                WeaponProperty.TwoHanded,
                WeaponProperty.Range
            })
    {
    }
}
