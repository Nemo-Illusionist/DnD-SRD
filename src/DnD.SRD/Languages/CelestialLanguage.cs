namespace DnD.SRD.Languages;

public sealed class CelestialLanguage : Language
{
    public CelestialLanguage()
        : base(LanguageType.Celestial, LanguageScriptType.Celestial, isExotic: true)
    {
    }
}