namespace DnD.SRD.Tags;

public partial class Tage
{
    public static class Damage
    {
        public static Tage Acid { get; } = new("damage_acid");
        public static Tage Lightning { get; } = new("damage_lightning");
        public static Tage Fire { get; } = new("damage_fire");
        public static Tage Poison { get; } = new("damage_poison");
        public static Tage Cold { get; } = new("damage_cold");
        public static Tage Electricity { get; } = new("damage_electricity");

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
