using DnD.SRD.Languages;

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
        public static Tage Celestial { get; } = new("language_celestial");
        public static Tage Draconic { get; } = new("language_draconic");
        public static Tage DeepSpeech { get; } = new("language_deep_speech");
        public static Tage Infernal { get; } = new("language_infernal");
        public static Tage Primordial { get; } = new("language_primordial");
        public static Tage Sylvan { get; } = new("language_sylvan");
        public static Tage Undercommon { get; } = new("language_undercommon");

        public static Tage? ByType(LanguageType type) => type switch
        {
            LanguageType.Common => Common,
            LanguageType.Dwarvish => Dwarvish,
            LanguageType.Elvish => Elvish,
            LanguageType.Giant => Giant,
            LanguageType.Gnomish => Gnomish,
            LanguageType.Goblin => Goblin,
            LanguageType.Halfling => Halfling,
            LanguageType.Orc => Orc,
            LanguageType.Abyssal => Abyssal,
            LanguageType.Celestial => Celestial,
            LanguageType.Draconic => Draconic,
            LanguageType.DeepSpeech => DeepSpeech,
            LanguageType.Infernal => Infernal,
            LanguageType.Primordial => Primordial,
            LanguageType.Sylvan => Sylvan,
            LanguageType.Undercommon => Undercommon,
            _ => null
        };
    }

    public static class LanguageScript
    {
        public static Tage Common { get; } = new("language_script_common");
        public static Tage Dwarvish { get; } = new("language_script_dwarvish");
        public static Tage Elvish { get; } = new("language_script_elvish");
        public static Tage Infernal { get; } = new("language_script_infernal");
        public static Tage Celestial { get; } = new("language_script_celestial");
        public static Tage Draconic { get; } = new("language_script_draconic");

        public static Tage? ByType(LanguageScriptType type) => type switch
        {
            LanguageScriptType.Common => Common,
            LanguageScriptType.Dwarvish => Dwarvish,
            LanguageScriptType.Elvish => Elvish,
            LanguageScriptType.Infernal => Infernal,
            LanguageScriptType.Celestial => Celestial,
            LanguageScriptType.Draconic => Draconic,
            _ => null
        };
    }
}
