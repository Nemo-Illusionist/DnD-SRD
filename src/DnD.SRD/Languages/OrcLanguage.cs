namespace DnD.SRD.Languages;

public sealed class OrcLanguage : Language
{
    public OrcLanguage()
        : base(LanguageType.Orc, LanguageScriptType.Dwarvish, isExotic: false)
    {
    }
}