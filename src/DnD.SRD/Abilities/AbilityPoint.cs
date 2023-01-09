namespace DnD.SRD.Abilities;

public abstract record AbilityPoint
{
    protected AbilityPoint(int score, AbilityPointType type, bool isSavingThrows)
    {
        if (score is < 0 or > MaxScore)
        {
            throw new ArgumentOutOfRangeException(nameof(score));
        }

        Score = score;
        Type = type;
        IsSavingThrows = isSavingThrows;
        SkillTypes = Array.Empty<SkillType>();
    }

    public const int MaxScore = 30;
    public int Score { get; }
    public AbilityPointType Type { get; }
    public bool IsSavingThrows { get; }
    public virtual IReadOnlyCollection<SkillType> SkillTypes { get; }
    public int Modifier => Score / 2 - 5;

    internal abstract SkillMode GetSkillMode(SkillType type);

    protected static SkillMode TryGetSkillMode(SkillType type, IReadOnlyDictionary<SkillType, SkillMode>? skillModes)
        => skillModes?.ContainsKey(type) ?? false
            ? skillModes[type]
            : SkillMode.None;

    protected static int PointScore(AbilityPoint point1, AbilityPoint point2)
    {
        var score = point1.Score + point2.Score;
        return score > MaxScore ? MaxScore : score;
    }

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
