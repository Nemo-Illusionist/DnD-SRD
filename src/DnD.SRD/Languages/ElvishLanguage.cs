namespace DnD.SRD.Languages;

public sealed class ElvishLanguage : Language
{
    public ElvishLanguage()
        : base(LanguageType.Elvish, LanguageScriptType.Elvish, isExotic: false)
    {
    }
}