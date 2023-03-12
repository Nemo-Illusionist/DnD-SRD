using DnD.SRD.Tags;

namespace DnD.SRD.Equipments.Weapons;

public class Blowgun : Weapon
{
    public Blowgun()
        : base(
            damage: 1,
            DamageType.Piercing,
            weight: 1,
            WeaponType.Martial,
            WeaponSubType.Blowgun,
            range: new WeaponRange(25, 100),
            property: new[] { WeaponProperty.Ammunition, WeaponProperty.Loading, WeaponProperty.Range })
    {
    }
}