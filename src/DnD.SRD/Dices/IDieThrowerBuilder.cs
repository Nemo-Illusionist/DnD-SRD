namespace DnD.SRD.Dices;

public interface IDieThrowerBuilder
{
    void AddScore(int score);
    void AddMode(ThrowMode mode);

    IDieThrower Build();
}
