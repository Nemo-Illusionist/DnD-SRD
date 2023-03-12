using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Greatclub : Weapon
{
    public Greatclub()
        : base(
            DiceType.D8,
            DamageType.Bludgeoning,
            weight: 10,
            WeaponType.Simple,
            WeaponSubType.Greatclub,
            property: new[] { WeaponProperty.TwoHanded })
    {
    }
}