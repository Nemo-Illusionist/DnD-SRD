using DnD.SRD.Characters;

namespace DnD.SRD.Abilities;

public abstract record AbilityPoint
{
    protected const int MaxAbilityScore = 30;
    public int Score { get; }
    public AbilityType Type { get; }
    public bool IsSavingThrows { get; }
    public virtual IReadOnlyCollection<SkillType> SkillTypes { get; }
    public int Modifier => Score / 2 - 5;

    protected AbilityPoint(int score, AbilityType type, bool isSavingThrows)
    {
        if (score is < 0 or > MaxAbilityScore)
        {
            throw new ArgumentOutOfRangeException(nameof(score));
        }

        Score = score;
        Type = type;
        IsSavingThrows = isSavingThrows;
        SkillTypes = Array.Empty<SkillType>();
    }

    public int GetSavingThrowsModifier(Advancement advancement)
    {
        ArgumentNullException.ThrowIfNull(advancement);

        return Modifier + (IsSavingThrows ? advancement.ProficiencyBonus : 0);
    }

    public int GetSkillModifier(SkillType type, Advancement advancement)
    {
        ArgumentNullException.ThrowIfNull(advancement);

        return Modifier + GetSkillModeByType(type) switch
        {
            SkillMode.None => 0,
            SkillMode.Half => advancement.ProficiencyBonus / 2,
            SkillMode.One => advancement.ProficiencyBonus,
            SkillMode.Two => advancement.ProficiencyBonus * 2,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }

    protected abstract SkillMode GetSkillModeByType(SkillType type);

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
