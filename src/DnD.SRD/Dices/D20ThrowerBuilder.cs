namespace DnD.SRD.Dices;

public sealed class D20ThrowerBuilder : ID20ThrowerBuilder
{
    public D20ThrowerBuilder(int score)
    {
        if (score <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(score));
        }

        Score = score;
    }

    public int Score { get; }

    public ThrowMode Mode => ThrowMode.None;
}
