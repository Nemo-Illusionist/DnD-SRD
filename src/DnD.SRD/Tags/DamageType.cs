namespace DnD.SRD.Tags;

public class DamageType : Tage
{
    protected DamageType(string id) : base(id)
    {
    }

    public static DamageType None { get; } = new("none");
    public static DamageType Acid { get; } = new("acid");
    public static DamageType Lightning { get; } = new("lightning");
    public static DamageType Fire { get; } = new("fire");
    public static DamageType Poison { get; } = new("poison");
    public static DamageType Cold { get; } = new("cold");
    public static DamageType Electricity { get; } = new("electricity");
    public static DamageType Bludgeoning { get; } = new("bludgeoning");
    public static DamageType Piercing { get; } = new("piercing");
    public static DamageType Slashing { get; } = new("slashing");
}
