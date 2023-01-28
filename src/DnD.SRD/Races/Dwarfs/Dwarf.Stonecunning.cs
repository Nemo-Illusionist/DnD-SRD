using DnD.SRD.Abilities;
using DnD.SRD.Abilities.Actions;
using DnD.SRD.Abilities.Behaviors;
using DnD.SRD.Actions.Behaviors;
using DnD.SRD.Characters;
using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Races.Dwarfs;

public partial class Dwarf : IActionBehaviorWrapper<ISkillCheckBehavior>
{
    public ISkillCheckBehavior Wrap(ISkillCheckBehavior behavior)
    {
        return new StonecunningSkillCheckBehavior(behavior);
    }

    private class StonecunningSkillCheckBehavior : ISkillCheckBehavior
    {
        private readonly ISkillCheckBehavior _skillCheckBehavior;

        public StonecunningSkillCheckBehavior(ISkillCheckBehavior skillCheckBehavior)
        {
            ArgumentNullException.ThrowIfNull(skillCheckBehavior);

            _skillCheckBehavior = skillCheckBehavior;
        }

        public Character Character => _skillCheckBehavior.Character;

        public ID20ThrowerBuilder Handel(SkillCheckAction action)
        {
            ArgumentNullException.ThrowIfNull(action);

            var d20ThrowerBuilder = _skillCheckBehavior.Handel(action);

            if (action.SkillType == SkillType.History && action.Tags.Contains(Tage.Environment.Stonework))
            {
                var ability = Character.GetCharacterAbility();
                var score = Math.Max(
                    ability.Intelligence.Modifier + Character.Advancement.GetProficiencyBonus() * 2,
                    d20ThrowerBuilder.Score);
                d20ThrowerBuilder = new D20ThrowerBuilder(score);
            }

            return d20ThrowerBuilder;
        }
    }
}
