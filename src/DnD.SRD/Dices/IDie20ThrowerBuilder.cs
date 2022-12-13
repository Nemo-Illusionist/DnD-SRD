using DnD.SRD.Abilities;

namespace DnD.SRD.Dices;

public interface IDie20ThrowerBuilder
{
    internal void AddScoreMode(int score);
    void AddMode(ThrowMode mode);
}

public class Die20ThrowerBuilder : IDie20ThrowerBuilder
{
    private bool _isInterference = false;
    private bool _isAdvantage = false;

    public Die20ThrowerBuilder(int score)
    {
        if (score <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(score));
        }

        Score = score;
    }

    public int Score { get; }

    public int? ScoreMode { get; private set; }

    public ThrowMode Mode => _isInterference != _isAdvantage
        ? _isAdvantage
            ? ThrowMode.Advantage
            : ThrowMode.Interference
        : ThrowMode.Standard;

    void IDie20ThrowerBuilder.AddScoreMode(int scoreMode)
    {
        if (scoreMode <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(scoreMode));
        }

        if (ScoreMode is not null)
        {
            throw new InvalidOperationException("ScoreMode is already set");
        }

        ScoreMode = scoreMode;
    }

    public void AddMode(ThrowMode mode)
    {
        switch (mode)
        {
            case ThrowMode.Interference:
                _isInterference = true;
                break;
            case ThrowMode.Advantage:
                _isAdvantage = true;
                break;
            case ThrowMode.Standard:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
        }
    }
}
