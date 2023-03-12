namespace DnD.SRD.Equipments.Coins;

public sealed record Coin
{
    public Coin(int value, CoinType type)
    {
        if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));

        Value = value;
        Type = type;
    }

    public int Value { get; }
    public CoinType Type { get; }
}
