namespace DnD.SRD.Languages;

public sealed class CommonLanguage : Language
{
    public CommonLanguage()
        : base(LanguageTage.Common, LanguageScriptTage.Common, isExotic: false)
    {
    }
}
