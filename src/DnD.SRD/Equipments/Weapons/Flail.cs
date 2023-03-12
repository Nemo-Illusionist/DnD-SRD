using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Flail : Weapon
{
    public Flail()
        : base(
            DiceType.D8,
            DamageType.Bludgeoning,
            weight: 2,
            WeaponType.Martial,
            WeaponSubType.Flail)
    {
    }
}
