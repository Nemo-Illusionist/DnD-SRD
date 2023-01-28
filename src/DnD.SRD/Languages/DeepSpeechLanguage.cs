namespace DnD.SRD.Languages;

public sealed class DeepSpeechLanguage : Language
{
    public DeepSpeechLanguage()
        : base(LanguageType.DeepSpeech, LanguageScriptType.None, isExotic: true)
    {
    }
}