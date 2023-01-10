using DnD.SRD.Abilities.Actions;
using DnD.SRD.Actions.Behaviors;
using DnD.SRD.Dices;

namespace DnD.SRD.Abilities.Behaviors;

public interface IAbilityCheckBehavior : IActionBehavior
{
    ID20ThrowerBuilder Handel(IAbilityCheckAction action);
}