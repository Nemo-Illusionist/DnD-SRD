namespace DnD.SRD.Abilities;

public abstract record AbilityPoint
{
    protected const int MaxAbilityScore = 30;
    public int Score { get; }
    public bool IsSavingThrows { get; }
    public int Modifier => Score / 2 - 5;

    protected AbilityPoint(int score, bool isSavingThrows)
    {
        if (score is < 0 or > MaxAbilityScore)
        {
            throw new ArgumentOutOfRangeException(nameof(score));
        }

        Score = score;
        IsSavingThrows = isSavingThrows;
    }

    protected static SkillMode TryGetSkillMode(SkillType type, IReadOnlyDictionary<SkillType, SkillMode>? skillModes)
        => skillModes?.ContainsKey(type) ?? false
            ? skillModes[type]
            : SkillMode.None;

    protected static SkillMode MaxSkillMode(SkillMode mode1, SkillMode mode2)
    {
        var mode = SkillMode.None;
        if (mode1 == SkillMode.Two || mode2 == SkillMode.Two)
        {
            mode = SkillMode.Two;
        }
        else if (mode1 == SkillMode.One || mode2 == SkillMode.One)
        {
            mode = SkillMode.One;
        }
        else if (mode1 == SkillMode.Half || mode2 == SkillMode.Half)
        {
            mode = SkillMode.Half;
        }

        return mode;
    }
}
