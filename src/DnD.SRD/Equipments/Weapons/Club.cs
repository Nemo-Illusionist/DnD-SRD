using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Club : Weapon
{
    public Club()
        : base(
            DiceType.D4,
            DamageType.Bludgeoning,
            weight: 2,
            WeaponType.Simple,
            WeaponSubType.Club,
            property: new[] { WeaponProperty.Light })
    {
    }
}
