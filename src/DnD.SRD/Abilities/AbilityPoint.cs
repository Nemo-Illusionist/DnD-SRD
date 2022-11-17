namespace DnD.SRD.Abilities;

public sealed record AbilityPoint
{
    public int Score { get; }
    public int Modifier => Score / 2 - 5;

    public AbilityPoint(int score)
    {
        // todo: Value must be between 1 and 30

        Score = score;
    }

    private AbilityPoint()
    {
        Score = 0;
    }

    public static AbilityPoint Empty { get; } = new();

    public static AbilityPoint operator +(AbilityPoint point1, AbilityPoint point2)
    {
        var score = point1.Score + point2.Score;
        return score > 30
            ? new AbilityPoint(30)
            : new AbilityPoint(score);
    }
}
