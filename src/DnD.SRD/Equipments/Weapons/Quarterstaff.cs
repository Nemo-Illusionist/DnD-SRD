using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Quarterstaff : Weapon
{
    public Quarterstaff()
        : base(
            DiceType.D6,
            DamageType.Bludgeoning,
            weight: 4,
            WeaponType.Simple,
            WeaponSubType.Quarterstaff,
            versatileDice: DiceType.D8,
            property: new[] { WeaponProperty.Versatile })
    {
    }
}
