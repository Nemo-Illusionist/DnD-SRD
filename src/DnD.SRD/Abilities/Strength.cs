namespace DnD.SRD.Abilities;

public sealed record Strength : AbilityPoint
{
    private static readonly SkillType[] SkillTypesArray = { SkillType.Athletics };

    internal Strength(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, AbilityPointType.Strength, isSavingThrows)
    {
        Athletics = TryGetSkillMode(SkillType.Athletics, skillModes);
    }

    public SkillMode Athletics { get; }
    public override IReadOnlyCollection<SkillType> SkillTypes => SkillTypesArray;

    internal override SkillMode GetSkillMode(SkillType type)
        => type switch
        {
            SkillType.Athletics => Athletics,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

    public static Strength operator +(Strength point1, Strength point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = PointScore(point1, point2);
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
            { { SkillType.Athletics, MaxSkillMode(point1.Athletics, point2.Athletics) } };
        return new Strength(score, isSavingThrows, skillModes);
    }
}
