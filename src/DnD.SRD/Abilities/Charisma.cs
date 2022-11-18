namespace DnD.SRD.Abilities;

public sealed record Charisma : AbilityPoint
{
    public SkillMode Deception { get; }
    public SkillMode Intimidation { get; }
    public SkillMode Performance { get; }
    public SkillMode Persuasion { get; }

    internal Charisma(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, isSavingThrows)
    {
        Deception = TryGetSkillMode(SkillType.Deception, skillModes);
        Intimidation = TryGetSkillMode(SkillType.Intimidation, skillModes);
        Performance = TryGetSkillMode(SkillType.Performance, skillModes);
        Persuasion = TryGetSkillMode(SkillType.Persuasion, skillModes);
    }

    public static Charisma operator +(Charisma point1, Charisma point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = point1.Score + point2.Score;
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
        {
            { SkillType.Deception, MaxSkillMode(point1.Deception, point2.Deception) },
            { SkillType.Intimidation, MaxSkillMode(point1.Intimidation, point2.Intimidation) },
            { SkillType.Performance, MaxSkillMode(point1.Performance, point2.Performance) },
            { SkillType.Persuasion, MaxSkillMode(point1.Persuasion, point2.Persuasion) }
        };
        return score > MaxAbilityScore
            ? new Charisma(30, isSavingThrows, skillModes)
            : new Charisma(score, isSavingThrows, skillModes);
    }
}
