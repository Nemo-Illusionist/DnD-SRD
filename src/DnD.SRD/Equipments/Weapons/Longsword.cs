using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Longsword : Weapon
{
    public Longsword()
        : base(
            DiceType.D8,
            DamageType.Slashing,
            weight: 3,
            WeaponType.Martial,
            WeaponSubType.Longsword,
            property: new[] { WeaponProperty.Versatile }, versatileDice: DiceType.D10)
    {
    }
}
