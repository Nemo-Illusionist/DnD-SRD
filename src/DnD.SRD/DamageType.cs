using DnD.SRD.Tags;

namespace DnD.SRD;

public class DamageType : Tage
{
    protected DamageType(string id) : base(id)
    {
    }

    public static DamageType Acid { get; } = new("acid");
    public static DamageType Lightning { get; } = new("lightning");
    public static DamageType Fire { get; } = new("fire");
    public static DamageType Poison { get; } = new("poison");
    public static DamageType Cold { get; } = new("cold");
    public static DamageType Electricity { get; } = new("electricity");
}
