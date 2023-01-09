namespace DnD.SRD.Abilities;

public sealed record Constitution : AbilityPoint
{
    internal Constitution(
        int score = 0,
        bool isSavingThrows = false)
        : base(score, AbilityPointType.Strength, isSavingThrows)
    {
    }

    internal override SkillMode GetSkillMode(SkillType type)
        => throw new ArgumentOutOfRangeException(nameof(type), type, null);

    public static Constitution operator +(Constitution point1, Constitution point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var score = PointScore(point1, point2);
        var isSavingThrows = point1.IsSavingThrows || point2.IsSavingThrows;
        return new Constitution(score, isSavingThrows);
    }
}
