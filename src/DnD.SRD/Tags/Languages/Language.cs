namespace DnD.SRD.Tags.Languages;

public abstract class Language : IEquatable<Language>
{
    protected Language(LanguageTage? languageType, LanguageScriptTage? scriptType, bool isExotic)
    {
        if (languageType is null && scriptType is null)
        {
            throw new ArgumentException($"{nameof(languageType)} or {nameof(scriptType)} required");
        }

        LanguageType = languageType;
        ScriptType = scriptType;
        IsExotic = isExotic;
    }

    public LanguageTage? LanguageType { get; }
    public LanguageScriptTage? ScriptType { get; }
    public bool IsExotic { get; }

    public bool Equals(Language? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Equals(LanguageType, other.LanguageType)
               && Equals(ScriptType, other.ScriptType)
               && IsExotic == other.IsExotic;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Language)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(LanguageType, ScriptType, IsExotic);
    }
}
