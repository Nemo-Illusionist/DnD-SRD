namespace DnD.SRD.Abilities;

public sealed record Strength : AbilityPoint
{
    public SkillMode Athletics { get; }
    public override IReadOnlyCollection<SkillType> SkillTypes => SkillTypesArray;

    private static readonly SkillType[] SkillTypesArray = { SkillType.Athletics };

    internal Strength(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, AbilityType.Strength, isSavingThrows)
    {
        Athletics = TryGetSkillMode(SkillType.Athletics, skillModes);
    }

    protected override SkillMode GetSkillModeByType(SkillType type)
        => type switch
        {
            SkillType.Athletics => Athletics,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

    public static Strength operator +(Strength point1, Strength point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = point1.Score + point2.Score;
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
            { { SkillType.Athletics, MaxSkillMode(point1.Athletics, point2.Athletics) } };
        return score > MaxAbilityScore
            ? new Strength(30, isSavingThrows, skillModes)
            : new Strength(score, isSavingThrows, skillModes);
    }
}
