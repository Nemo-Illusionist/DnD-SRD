using DnD.SRD.Tags;

namespace DnD.SRD.Languages;

public class LanguageScriptTage : Tage
{
    private LanguageScriptTage(string id) : base(id)
    {
    }

    public static LanguageScriptTage Common { get; } = new("language_script_common");
    public static LanguageScriptTage Dwarvish { get; } = new("language_script_dwarvish");
    public static LanguageScriptTage Elvish { get; } = new("language_script_elvish");
    public static LanguageScriptTage Infernal { get; } = new("language_script_infernal");
    public static LanguageScriptTage Celestial { get; } = new("language_script_celestial");
    public static LanguageScriptTage Draconic { get; } = new("language_script_draconic");
}
