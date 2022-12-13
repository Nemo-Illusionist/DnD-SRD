namespace DnD.SRD.Abilities;

public sealed record Dexterity : AbilityPoint
{
    public SkillMode Acrobatics { get; }
    public SkillMode SleightOfHand { get; }
    public SkillMode Stealth { get; }
    public override IReadOnlyCollection<SkillType> SkillTypes => SkillTypesArray;

    private static readonly SkillType[] SkillTypesArray =
        { SkillType.Acrobatics, SkillType.SleightOfHand, SkillType.Stealth };

    internal Dexterity(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, AbilityPointType.Strength, isSavingThrows)
    {
        Acrobatics = TryGetSkillMode(SkillType.Acrobatics, skillModes);
        SleightOfHand = TryGetSkillMode(SkillType.SleightOfHand, skillModes);
        Stealth = TryGetSkillMode(SkillType.Stealth, skillModes);
    }

    internal override SkillMode GetSkillModeByType(SkillType type)
        => type switch
        {
            SkillType.Acrobatics => Acrobatics,
            SkillType.SleightOfHand => SleightOfHand,
            SkillType.Stealth => Stealth,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

    public static Dexterity operator +(Dexterity point1, Dexterity point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = PointScore(point1, point2);
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
        {
            { SkillType.Acrobatics, MaxSkillMode(point1.Acrobatics, point2.Acrobatics) },
            { SkillType.SleightOfHand, MaxSkillMode(point1.SleightOfHand, point2.SleightOfHand) },
            { SkillType.Stealth, MaxSkillMode(point1.Stealth, point2.Stealth) }
        };
        return new Dexterity(score, isSavingThrows, skillModes);
    }
}
