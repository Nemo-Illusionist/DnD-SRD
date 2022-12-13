namespace DnD.SRD.Abilities;

public sealed record Charisma : AbilityPoint
{
    public SkillMode Deception { get; }
    public SkillMode Intimidation { get; }
    public SkillMode Performance { get; }
    public SkillMode Persuasion { get; }
    public override IReadOnlyCollection<SkillType> SkillTypes => SkillTypesArray;

    private static readonly SkillType[] SkillTypesArray =
        { SkillType.Deception, SkillType.Intimidation, SkillType.Performance, SkillType.Persuasion };

    internal Charisma(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, AbilityPointType.Charisma, isSavingThrows)
    {
        Deception = TryGetSkillMode(SkillType.Deception, skillModes);
        Intimidation = TryGetSkillMode(SkillType.Intimidation, skillModes);
        Performance = TryGetSkillMode(SkillType.Performance, skillModes);
        Persuasion = TryGetSkillMode(SkillType.Persuasion, skillModes);
    }

    internal override SkillMode GetSkillModeByType(SkillType type)
        => type switch
        {
            SkillType.Deception => Deception,
            SkillType.Intimidation => Intimidation,
            SkillType.Performance => Performance,
            SkillType.Persuasion => Persuasion,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

    public static Charisma operator +(Charisma point1, Charisma point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = PointScore(point1, point2);
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
        {
            { SkillType.Deception, MaxSkillMode(point1.Deception, point2.Deception) },
            { SkillType.Intimidation, MaxSkillMode(point1.Intimidation, point2.Intimidation) },
            { SkillType.Performance, MaxSkillMode(point1.Performance, point2.Performance) },
            { SkillType.Persuasion, MaxSkillMode(point1.Persuasion, point2.Persuasion) }
        };
        return new Charisma(score, isSavingThrows, skillModes);
    }
}
