namespace DnD.SRD.Languages;

public sealed class HalflingLanguage : Language
{
    public HalflingLanguage()
        : base(LanguageType.Halfling, LanguageScriptType.Common, isExotic: false)
    {
    }
}