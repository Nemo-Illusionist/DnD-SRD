namespace DnD.SRD.Races.Sizes;

public record Size
{
    public Size(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value));
        }

        Value = value;
    }

    public double Value { get; }

    public SizeType Type => Value switch
    {
        >= 20 => SizeType.Gargantuan,
        >= 15 => SizeType.Huge,
        >= 10 => SizeType.Large,
        >= 4 => SizeType.Medium,
        >= 2.5 => SizeType.Small,
        > 0 => SizeType.Tiny,
        _ => throw new ArgumentOutOfRangeException()
    };
}
