namespace DnD.SRD.Languages;

public sealed class AbyssalLanguage : Language
{
    public AbyssalLanguage()
        : base(LanguageType.Abyssal, LanguageScriptType.Infernal, isExotic: true)
    {
    }
}