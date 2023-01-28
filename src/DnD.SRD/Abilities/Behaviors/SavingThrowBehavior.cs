using DnD.SRD.Abilities.Actions;
using DnD.SRD.Actions.Behaviors;
using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Abilities.Behaviors;

internal class SavingThrowBehavior : BaseActionBehavior<SavingThrowAction>, ISavingThrowBehavior
{
    public SavingThrowBehavior(Character character) : base(character)
    {
    }

    public override ID20ThrowerBuilder Handel(SavingThrowAction action)
    {
        ArgumentNullException.ThrowIfNull(action);

        var ability = Character.GetCharacterAbility();
        var point = ability.GetPoint(action.AbilityType);
        var score = point.Modifier + (point.IsSavingThrows ? Character.Advancement.GetProficiencyBonus() : 0);

        return new D20ThrowerBuilder(score);
    }
}
