namespace DnD.SRD.Languages;

public sealed class GoblinLanguage : Language
{
    public GoblinLanguage()
        : base(LanguageType.Goblin, LanguageScriptType.Dwarvish, isExotic: false)
    {
    }
}