using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class WarPick : Weapon
{
    public WarPick()
        : base(
            DiceType.D8,
            DamageType.Piercing,
            weight: 2,
            WeaponType.Martial,
            WeaponSubType.WarPick)
    {
    }
}
