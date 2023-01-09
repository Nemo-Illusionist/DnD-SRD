namespace DnD.SRD.Tags;

public partial class Tage
{
    public static class Damage
    {
        public static Tage Acid { get; } = new("acid");
        public static Tage Lightning { get; } = new("lightning");
        public static Tage Fire { get; } = new("fire");
        public static Tage Poison { get; } = new("poison");
        public static Tage Cold { get; } = new("cold");
        public static Tage Electricity { get; } = new("electricity");

        public static Tage? ByType(DamageType type)
        {
            return type switch
            {
                DamageType.None => null,
                DamageType.Acid => Acid,
                DamageType.Lightning => Lightning,
                DamageType.Fire => Fire,
                DamageType.Poison => Poison,
                DamageType.Cold => Cold,
                DamageType.Electricity => Electricity,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}
