namespace DnD.SRD.Languages;

public sealed class InfernalLanguage : Language
{
    public InfernalLanguage()
        : base(LanguageTage.Infernal, LanguageScriptTage.Infernal, isExotic: true)
    {
    }
}
