namespace DnD.SRD.Abilities;

public sealed record Intelligence : AbilityPoint
{
    private static readonly SkillType[] SkillTypesArray =
        { SkillType.Arcana, SkillType.History, SkillType.Investigation, SkillType.Nature, SkillType.Religion };

    internal Intelligence(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, AbilityPointType.Strength, isSavingThrows)
    {
        Arcana = TryGetSkillMode(SkillType.Arcana, skillModes);
        History = TryGetSkillMode(SkillType.History, skillModes);
        Investigation = TryGetSkillMode(SkillType.Investigation, skillModes);
        Nature = TryGetSkillMode(SkillType.Nature, skillModes);
        Religion = TryGetSkillMode(SkillType.Religion, skillModes);
    }

    public SkillMode Arcana { get; }
    public SkillMode History { get; }
    public SkillMode Investigation { get; }
    public SkillMode Nature { get; }
    public SkillMode Religion { get; }
    public override IReadOnlyCollection<SkillType> SkillTypes => SkillTypesArray;

    internal override SkillMode GetSkillMode(SkillType type)
        => type switch
        {
            SkillType.Arcana => Arcana,
            SkillType.History => History,
            SkillType.Investigation => Investigation,
            SkillType.Nature => Nature,
            SkillType.Religion => Religion,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

    public static Intelligence operator +(Intelligence point1, Intelligence point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = PointScore(point1, point2);
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
        {
            { SkillType.Arcana, MaxSkillMode(point1.Arcana, point2.Arcana) },
            { SkillType.History, MaxSkillMode(point1.History, point2.History) },
            { SkillType.Investigation, MaxSkillMode(point1.Investigation, point2.Investigation) },
            { SkillType.Nature, MaxSkillMode(point1.Nature, point2.Nature) },
            { SkillType.Religion, MaxSkillMode(point1.Religion, point2.Religion) }
        };
        return new Intelligence(score, isSavingThrows, skillModes);
    }
}
