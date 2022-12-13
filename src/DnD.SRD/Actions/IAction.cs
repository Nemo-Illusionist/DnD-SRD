using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Actions;

public interface IAction
{
    public Character Who { get; }
    public IDieThrowerBuilder DieThrowerBuilder { get; }
    public IReadOnlyCollection<Tage> Tags { get; }
}
