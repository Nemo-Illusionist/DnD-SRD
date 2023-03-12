using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Shortsword : Weapon
{
    public Shortsword()
        : base(
            DiceType.D6,
            DamageType.Piercing,
            weight: 2,
            WeaponType.Martial,
            WeaponSubType.Shortsword,
            property: new[] { WeaponProperty.Finesse, WeaponProperty.Light })
    {
    }
}
