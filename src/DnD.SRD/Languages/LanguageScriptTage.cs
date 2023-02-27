using DnD.SRD.Tags;

namespace DnD.SRD.Languages;

public class LanguageScriptTage : Tage
{
    protected LanguageScriptTage(string id) : base(id)
    {
    }

    public static LanguageScriptTage Common { get; } = new("common");
    public static LanguageScriptTage Dwarvish { get; } = new("dwarvish");
    public static LanguageScriptTage Elvish { get; } = new("elvish");
    public static LanguageScriptTage Infernal { get; } = new("infernal");
    public static LanguageScriptTage Celestial { get; } = new("celestial");
    public static LanguageScriptTage Draconic { get; } = new("draconic");
}
