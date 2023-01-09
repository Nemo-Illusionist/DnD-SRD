namespace DnD.SRD.Dices;

public interface ID20ThrowerBuilder
{
    int Score { get; }
    ThrowMode Mode { get; }
}