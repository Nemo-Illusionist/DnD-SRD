namespace DnD.SRD.Tags;

public partial class Tage
{
    public static class Language
    {
        public static Tage Common { get; } = new("language_common");
        public static Tage Dwarvish { get; } = new("language_dwarvish");
        public static Tage Elvish { get; } = new("language_elvish");
        public static Tage Giant { get; } = new("language_giant");
        public static Tage Gnomish { get; } = new("language_gnomish");
        public static Tage Goblin { get; } = new("language_goblin");
        public static Tage Halfling { get; } = new("language_halfling");
        public static Tage Orc { get; } = new("language_orc");
        public static Tage Abyssal { get; } = new("language_abyssal");
        public static Tage Draconic { get; } = new("language_draconic");
        public static Tage DeepSpeech { get; } = new("language_deep_speech");
        public static Tage Infernal { get; } = new("language_infernal");
        public static Tage Primordial { get; } = new("language_primordial");
        public static Tage Sylvan { get; } = new("language_sylvan");
        public static Tage Undercommon { get; } = new("language_undercommon");
    }
}
