namespace DnD.SRD.Abilities;

public sealed record Constitution : AbilityPoint
{
    internal Constitution(
        int score = 0,
        bool isSavingThrows = false)
        : base(score, AbilityType.Strength, isSavingThrows)
    {
    }

    protected override SkillMode GetSkillModeByType(SkillType type)
        => throw new ArgumentOutOfRangeException(nameof(type), type, null);

    public static Constitution operator +(Constitution point1, Constitution point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = point1.Score + point2.Score;
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        return score > MaxAbilityScore
            ? new Constitution(30, isSavingThrows)
            : new Constitution(score, isSavingThrows);
    }
}
