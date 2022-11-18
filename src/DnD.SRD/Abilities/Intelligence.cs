namespace DnD.SRD.Abilities;

public sealed record Intelligence : AbilityPoint
{
    public SkillMode Arcana { get; }
    public SkillMode History { get; }
    public SkillMode Investigation { get; }
    public SkillMode Nature { get; }
    public SkillMode Religion { get; }

    internal Intelligence(
        int score = 0,
        bool isSavingThrows = false,
        IReadOnlyDictionary<SkillType, SkillMode>? skillModes = null)
        : base(score, isSavingThrows)
    {
        Arcana = TryGetSkillMode(SkillType.Arcana, skillModes);
        History = TryGetSkillMode(SkillType.History, skillModes);
        Investigation = TryGetSkillMode(SkillType.Investigation, skillModes);
        Nature = TryGetSkillMode(SkillType.Nature, skillModes);
        Religion = TryGetSkillMode(SkillType.Religion, skillModes);
    }

    public static Intelligence operator +(Intelligence point1, Intelligence point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = point1.Score + point2.Score;
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        var skillModes = new Dictionary<SkillType, SkillMode>
        {
            { SkillType.Arcana, MaxSkillMode(point1.Arcana, point2.Arcana) },
            { SkillType.History, MaxSkillMode(point1.History, point2.History) },
            { SkillType.Investigation, MaxSkillMode(point1.Investigation, point2.Investigation) },
            { SkillType.Nature, MaxSkillMode(point1.Nature, point2.Nature) },
            { SkillType.Religion, MaxSkillMode(point1.Religion, point2.Religion) }
        };
        return score > MaxAbilityScore
            ? new Intelligence(30, isSavingThrows, skillModes)
            : new Intelligence(score, isSavingThrows, skillModes);
    }
}
