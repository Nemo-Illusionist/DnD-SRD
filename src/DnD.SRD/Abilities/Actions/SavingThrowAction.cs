using DnD.SRD.Actions;
using DnD.SRD.Tags;

namespace DnD.SRD.Abilities.Actions;

public record SavingThrowAction : BaseAction
{
    public SavingThrowAction(IReadOnlyCollection<Tage> tags) : base(tags)
    {
    }

    public AbilityPointType AbilityType { get; set; }
}
