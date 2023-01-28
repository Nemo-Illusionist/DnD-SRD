namespace DnD.SRD.Languages;

public abstract class Language
{
    protected Language(LanguageType languageType, LanguageScriptType scriptType, bool isExotic)
    {
        LanguageType = languageType;
        ScriptType = scriptType;
        IsExotic = isExotic;
    }

    public LanguageType LanguageType { get; }
    public LanguageScriptType ScriptType { get; }
    public bool IsExotic { get; }
}
