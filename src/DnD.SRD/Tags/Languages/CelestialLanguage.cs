namespace DnD.SRD.Tags.Languages;

public sealed class CelestialLanguage : Language
{
    public CelestialLanguage()
        : base(LanguageTage.Celestial, LanguageScriptTage.Celestial, isExotic: true)
    {
    }
}
