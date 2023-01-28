using DnD.SRD.Tags;

namespace DnD.SRD.Actions;

public record BaseAction
{
    public BaseAction(IReadOnlyCollection<Tage> tags)
    {
        ArgumentNullException.ThrowIfNull(tags);

        Tags = tags;
    }

    public IReadOnlyCollection<Tage> Tags { get; }
}
