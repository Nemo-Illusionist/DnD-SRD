namespace DnD.SRD.Equipments.Weapons;

public class Net : Weapon
{
    public Net()
        : base(
            damage: 0,
            damageType: null,
            weight: 3,
            WeaponType.Martial,
            WeaponSubType.Net,
            range: new WeaponRange(5, 15),
            property: new[] { WeaponProperty.Thrown, WeaponProperty.Special, WeaponProperty.Range })
    {
    }
}