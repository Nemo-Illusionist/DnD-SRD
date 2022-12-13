using DnD.SRD.Dices;

namespace DnD.SRD.Actions;

public interface IAction
{
    public IDie20ThrowerBuilder DieThrowerBuilder { get; }
    public IReadOnlyCollection<Tage> Tags { get; }
}
