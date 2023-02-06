namespace DnD.SRD.Languages;

public sealed class GoblinLanguage : Language
{
    public GoblinLanguage()
        : base(LanguageTage.Goblin, LanguageScriptTage.Dwarvish, isExotic: false)
    {
    }
}
