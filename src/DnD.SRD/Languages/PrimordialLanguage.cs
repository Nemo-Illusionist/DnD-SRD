namespace DnD.SRD.Languages;

public sealed class PrimordialLanguage : Language
{
    public PrimordialLanguage()
        : base(LanguageType.Primordial, LanguageScriptType.Dwarvish, isExotic: true)
    {
    }
}