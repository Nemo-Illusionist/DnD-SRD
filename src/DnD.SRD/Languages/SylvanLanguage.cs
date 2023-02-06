namespace DnD.SRD.Languages;

public sealed class SylvanLanguage : Language
{
    public SylvanLanguage()
        : base(LanguageTage.Sylvan, LanguageScriptTage.Elvish, isExotic: true)
    {
    }
}
