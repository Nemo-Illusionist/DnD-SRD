using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Mace : Weapon
{
    public Mace()
        : base(
            DiceType.D6,
            DamageType.Bludgeoning,
            weight: 4,
            WeaponType.Simple,
            WeaponSubType.Mace)
    {
    }
}
