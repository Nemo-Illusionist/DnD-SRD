using DnD.SRD.Abilities;
using DnD.SRD.Abilities.Actions;
using DnD.SRD.Abilities.Behaviors;
using DnD.SRD.Characters;
using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Races.Dwarfs.Behaviors;

internal class StoneworkHistorySkillCheckBehavior : ISkillCheckBehavior
{
    private readonly ISkillCheckBehavior _skillCheckBehavior;

    public StoneworkHistorySkillCheckBehavior(ISkillCheckBehavior skillCheckBehavior)
    {
        ArgumentNullException.ThrowIfNull(skillCheckBehavior);

        _skillCheckBehavior = skillCheckBehavior;
    }

    public Character Character => _skillCheckBehavior.Character;

    public ID20ThrowerBuilder Handel(ISkillCheckAction action)
    {
        ArgumentNullException.ThrowIfNull(action);

        if (action.SkillType != SkillType.History || !action.Tags.Contains(Tage.Environment.Stonework))
        {
            return _skillCheckBehavior.Handel(action);
        }

        var ability = Character.GetCharacterAbility();
        var score = ability.Intelligence.Modifier + Character.Advancement.ProficiencyBonus * 2;
        return new D20ThrowerBuilder(score);
    }
}
