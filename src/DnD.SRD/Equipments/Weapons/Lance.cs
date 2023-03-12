using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Lance : Weapon
{
    public Lance()
        : base(
            DiceType.D12,
            DamageType.Piercing,
            weight: 6,
            WeaponType.Martial,
            WeaponSubType.Lance,
            property: new[] { WeaponProperty.Reach, WeaponProperty.Special })
    {
    }
}
