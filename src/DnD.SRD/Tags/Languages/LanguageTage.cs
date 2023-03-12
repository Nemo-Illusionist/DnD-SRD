namespace DnD.SRD.Tags.Languages;

public class LanguageTage : Tage
{
    protected LanguageTage(string id) : base(id)
    {
    }

    public static LanguageTage Common { get; } = new("common");
    public static LanguageTage Dwarvish { get; } = new("dwarvish");
    public static LanguageTage Elvish { get; } = new("elvish");
    public static LanguageTage Giant { get; } = new("giant");
    public static LanguageTage Gnomish { get; } = new("gnomish");
    public static LanguageTage Goblin { get; } = new("goblin");
    public static LanguageTage Halfling { get; } = new("halfling");
    public static LanguageTage Orc { get; } = new("orc");
    public static LanguageTage Abyssal { get; } = new("abyssal");
    public static LanguageTage Celestial { get; } = new("celestial");
    public static LanguageTage Draconic { get; } = new("draconic");
    public static LanguageTage DeepSpeech { get; } = new("deep_speech");
    public static LanguageTage Infernal { get; } = new("infernal");
    public static LanguageTage Primordial { get; } = new("primordial");
    public static LanguageTage Sylvan { get; } = new("sylvan");
    public static LanguageTage Undercommon { get; } = new("undercommon");
}
