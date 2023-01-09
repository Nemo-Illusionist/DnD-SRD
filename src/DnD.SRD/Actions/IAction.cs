using DnD.SRD.Tags;

namespace DnD.SRD.Actions;

public interface IAction
{
    public IReadOnlyCollection<Tage> Tags { get; }
}
