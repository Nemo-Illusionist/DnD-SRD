using System.ComponentModel;

namespace DnD.SRD.Dices;

public sealed class D20ThrowerModeWrapperBuilder : ID20ThrowerBuilder
{
    private readonly ThrowMode _mode;
    private readonly ID20ThrowerBuilder _d20ThrowerBuilder;

    public D20ThrowerModeWrapperBuilder(ThrowMode mode, ID20ThrowerBuilder d20ThrowerBuilder)
    {
        ArgumentNullException.ThrowIfNull(d20ThrowerBuilder);
        if (!Enum.IsDefined(typeof(ThrowMode), mode))
        {
            throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(ThrowMode));
        }

        _d20ThrowerBuilder = d20ThrowerBuilder;
        _mode = mode;
    }

    public int Score => _d20ThrowerBuilder.Score;

    public ThrowMode Mode => _d20ThrowerBuilder.Mode == ThrowMode.None || _d20ThrowerBuilder.Mode == _mode
        ? _mode
        : ThrowMode.Standard;
}
