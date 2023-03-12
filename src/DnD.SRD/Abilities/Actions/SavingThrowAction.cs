using DnD.SRD.Actions;
using DnD.SRD.Tags;

namespace DnD.SRD.Abilities.Actions;

public record SavingThrowAction : BaseAction
{
    public SavingThrowAction(
        AbilityPointType abilityType,
        IReadOnlyCollection<Tage> tags)
        : base(tags)
    {
        AbilityType = abilityType;
    }

    public AbilityPointType AbilityType { get; }
}
