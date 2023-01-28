namespace DnD.SRD.Languages;

public sealed class SylvanLanguage : Language
{
    public SylvanLanguage()
        : base(LanguageType.Sylvan, LanguageScriptType.Elvish, isExotic: true)
    {
    }
}