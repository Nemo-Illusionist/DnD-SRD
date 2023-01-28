namespace DnD.SRD.Languages;

public sealed class CommonLanguage : Language
{
    public CommonLanguage()
        : base(LanguageType.Common, LanguageScriptType.Common, isExotic: false)
    {
    }
}
