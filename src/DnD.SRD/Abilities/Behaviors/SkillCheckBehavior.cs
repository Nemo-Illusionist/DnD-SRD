using DnD.SRD.Abilities.Actions;
using DnD.SRD.Actions.Behaviors;
using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Abilities.Behaviors;

internal class SkillCheckBehavior : BaseActionBehavior<ISkillCheckAction>, ISkillCheckBehavior
{
    public SkillCheckBehavior(Character character) : base(character)
    {
    }

    public override ID20ThrowerBuilder Handel(ISkillCheckAction action)
    {
        ArgumentNullException.ThrowIfNull(action);

        var ability = Character.GetCharacterAbility();
        var point = ability.GetPoint(action.SkillType);
        var score = point.Modifier + point.GetSkillMode(action.SkillType) switch
        {
            SkillMode.None => 0,
            SkillMode.Half => Character.Advancement.ProficiencyBonus / 2,
            SkillMode.One => Character.Advancement.ProficiencyBonus,
            SkillMode.Two => Character.Advancement.ProficiencyBonus * 2,
            _ => throw new ArgumentOutOfRangeException()
        };

        return new D20ThrowerBuilder(score);
    }
}
