using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Greataxe : Weapon
{
    public Greataxe()
        : base(
            DiceType.D10,
            DamageType.Slashing,
            weight: 7,
            WeaponType.Martial,
            WeaponSubType.Greataxe,
            property: new[] { WeaponProperty.Heavy, WeaponProperty.TwoHanded })
    {
    }
}
