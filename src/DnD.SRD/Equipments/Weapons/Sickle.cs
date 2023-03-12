using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Sickle : Weapon
{
    public Sickle()
        : base(
            DiceType.D4,
            DamageType.Slashing,
            weight: 2,
            WeaponType.Simple,
            WeaponSubType.Sickle,
            property: new[] { WeaponProperty.Light })
    {
    }
}
