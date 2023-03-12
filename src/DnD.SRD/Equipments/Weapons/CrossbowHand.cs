using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class CrossbowHand : Weapon
{
    public CrossbowHand()
        : base(
            DiceType.D6,
            DamageType.Piercing,
            weight: 3,
            WeaponType.Martial,
            WeaponSubType.CrossbowHand,
            range: new WeaponRange(30, 120),
            property: new[] { WeaponProperty.Ammunition, WeaponProperty.Light, WeaponProperty.Loading })
    {
    }
}