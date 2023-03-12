using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Morningstar : Weapon
{
    public Morningstar()
        : base(
            DiceType.D8,
            DamageType.Piercing,
            weight: 4,
            WeaponType.Martial,
            WeaponSubType.Morningstar)
    {
    }
}
