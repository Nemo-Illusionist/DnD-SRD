using DnD.SRD.Abilities.Actions;
using DnD.SRD.Actions.Behaviors;
using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Abilities.Behaviors;

internal class AbilityCheckBehavior : BaseActionBehavior<IAbilityCheckAction>, IAbilityCheckBehavior
{
    public AbilityCheckBehavior(Character character) : base(character)
    {
    }

    public override ID20ThrowerBuilder Handel(IAbilityCheckAction action)
    {
        ArgumentNullException.ThrowIfNull(action);

        var ability = Character.GetCharacterAbility();
        var point = ability.GetPoint(action.AbilityType);
        var score = point.Modifier;

        return new D20ThrowerBuilder(score);
    }
}