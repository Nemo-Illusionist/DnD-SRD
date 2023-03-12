namespace DnD.SRD.Tags.Languages;

public sealed class HalflingLanguage : Language
{
    public HalflingLanguage()
        : base(LanguageTage.Halfling, LanguageScriptTage.Common, isExotic: false)
    {
    }
}
