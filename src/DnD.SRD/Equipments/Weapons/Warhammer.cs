using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Warhammer : Weapon
{
    public Warhammer()
        : base(
            DiceType.D8,
            DamageType.Bludgeoning,
            weight: 2,
            WeaponType.Martial,
            WeaponSubType.Warhammer,
            versatileDice: DiceType.D10,
            property: new[] { WeaponProperty.Versatile })
    {
    }
}
