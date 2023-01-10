using DnD.SRD.Actions;

namespace DnD.SRD.Abilities.Actions;

public interface ISavingThrowAction : IAction
{
    public AbilityPointType AbilityType { get; set; }
}