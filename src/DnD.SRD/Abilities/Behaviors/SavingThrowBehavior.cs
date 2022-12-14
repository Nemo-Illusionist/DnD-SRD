using DnD.SRD.Abilities.Actions;
using DnD.SRD.Actions.Behaviors;
using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Abilities.Behaviors;

internal class SavingThrowBehavior : BaseActionBehavior<ISavingThrowAction>, ISavingThrowBehavior
{
    public SavingThrowBehavior(Character character) : base(character)
    {
    }

    public override ID20ThrowerBuilder Handel(ISavingThrowAction action)
    {
        ArgumentNullException.ThrowIfNull(action);

        var ability = Character.GetCharacterAbility();
        var point = ability.GetPoint(action.AbilityType);
        var score = point.Modifier + (point.IsSavingThrows ? Character.Advancement.ProficiencyBonus : 0);

        return new D20ThrowerBuilder(score);
    }
}
