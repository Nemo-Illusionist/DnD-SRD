using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Rapier : Weapon
{
    public Rapier()
        : base(
            DiceType.D8,
            DamageType.Piercing,
            weight: 2,
            WeaponType.Martial,
            WeaponSubType.Rapier,
            property: new[] { WeaponProperty.Finesse })
    {
    }
}
