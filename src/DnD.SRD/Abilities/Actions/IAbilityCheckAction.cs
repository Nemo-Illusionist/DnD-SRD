using DnD.SRD.Actions;

namespace DnD.SRD.Abilities.Actions;

public interface IAbilityCheckAction : IAction
{
    public AbilityPointType AbilityType { get; set; }
}