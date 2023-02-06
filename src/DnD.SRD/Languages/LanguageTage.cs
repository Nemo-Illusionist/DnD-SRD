using DnD.SRD.Tags;

namespace DnD.SRD.Languages;

public class LanguageTage : Tage
{
    private LanguageTage(string id) : base(id)
    {
    }

    public static LanguageTage Common { get; } = new("language_common");
    public static LanguageTage Dwarvish { get; } = new("language_dwarvish");
    public static LanguageTage Elvish { get; } = new("language_elvish");
    public static LanguageTage Giant { get; } = new("language_giant");
    public static LanguageTage Gnomish { get; } = new("language_gnomish");
    public static LanguageTage Goblin { get; } = new("language_goblin");
    public static LanguageTage Halfling { get; } = new("language_halfling");
    public static LanguageTage Orc { get; } = new("language_orc");
    public static LanguageTage Abyssal { get; } = new("language_abyssal");
    public static LanguageTage Celestial { get; } = new("language_celestial");
    public static LanguageTage Draconic { get; } = new("language_draconic");
    public static LanguageTage DeepSpeech { get; } = new("language_deep_speech");
    public static LanguageTage Infernal { get; } = new("language_infernal");
    public static LanguageTage Primordial { get; } = new("language_primordial");
    public static LanguageTage Sylvan { get; } = new("language_sylvan");
    public static LanguageTage Undercommon { get; } = new("language_undercommon");
}
