namespace DnD.SRD.Equipments.Weapons;

public record WeaponRange
{
    public WeaponRange(int normal, int @long)
    {
        if (normal <= 0) throw new ArgumentOutOfRangeException(nameof(normal));
        if (@long <= 0) throw new ArgumentOutOfRangeException(nameof(@long));

        Normal = normal;
        Long = @long;
    }

    public int Normal { get; }
    public int Long { get; }
}