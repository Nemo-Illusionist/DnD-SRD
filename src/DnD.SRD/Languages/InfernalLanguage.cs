namespace DnD.SRD.Languages;

public sealed class InfernalLanguage : Language
{
    public InfernalLanguage()
        : base(LanguageType.Infernal, LanguageScriptType.Infernal, isExotic: true)
    {
    }
}