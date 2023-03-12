using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Scimitar : Weapon
{
    public Scimitar()
        : base(
            DiceType.D6,
            DamageType.Slashing,
            weight: 3,
            WeaponType.Martial,
            WeaponSubType.Scimitar,
            property: new[] { WeaponProperty.Finesse, WeaponProperty.Light })
    {
    }
}
