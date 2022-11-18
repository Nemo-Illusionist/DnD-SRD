namespace DnD.SRD.Abilities;

public sealed record Wisdom : AbilityPoint
{
    public SkillMode AnimalHandling { get; }
    public SkillMode Insight { get; }
    public SkillMode Medicine { get; }
    public SkillMode Perception { get; }
    public SkillMode Survival { get; }
    public override IReadOnlyCollection<SkillType> SkillTypes => SkillTypesArray;

    private static readonly SkillType[] SkillTypesArray =
        { SkillType.AnimalHandling, SkillType.Insight, SkillType.Medicine, SkillType.Perception, SkillType.Survival };

    internal Wisdom(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, AbilityType.Wisdom, isSavingThrows)
    {
        AnimalHandling = TryGetSkillMode(SkillType.AnimalHandling, skillModes);
        Insight = TryGetSkillMode(SkillType.Insight, skillModes);
        Medicine = TryGetSkillMode(SkillType.Medicine, skillModes);
        Perception = TryGetSkillMode(SkillType.Perception, skillModes);
        Survival = TryGetSkillMode(SkillType.Survival, skillModes);
    }

    protected override SkillMode GetSkillModeByType(SkillType type)
        => type switch
        {
            SkillType.AnimalHandling => AnimalHandling,
            SkillType.Insight => Insight,
            SkillType.Medicine => Medicine,
            SkillType.Perception => Perception,
            SkillType.Survival => Survival,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

    public static Wisdom operator +(Wisdom point1, Wisdom point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = point1.Score + point2.Score;
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
        {
            { SkillType.AnimalHandling, MaxSkillMode(point1.AnimalHandling, point2.AnimalHandling) },
            { SkillType.Insight, MaxSkillMode(point1.Insight, point2.Insight) },
            { SkillType.Medicine, MaxSkillMode(point1.Medicine, point2.Medicine) },
            { SkillType.Perception, MaxSkillMode(point1.Perception, point2.Perception) },
            { SkillType.Survival, MaxSkillMode(point1.Survival, point2.Survival) }
        };
        return score > MaxAbilityScore
            ? new Wisdom(30, isSavingThrows, skillModes)
            : new Wisdom(score, isSavingThrows, skillModes);
    }
}
