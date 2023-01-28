using DnD.SRD.Abilities.Actions;
using DnD.SRD.Abilities.Behaviors;
using DnD.SRD.Actions.Behaviors;
using DnD.SRD.Characters;
using DnD.SRD.Dices;
using DnD.SRD.Tags;

namespace DnD.SRD.Races.Dwarfs;

public partial class Dwarf : IActionBehaviorWrapper<ISavingThrowBehavior>
{
    public ISavingThrowBehavior Wrap(ISavingThrowBehavior behavior)
    {
        return new DwarvenResilienceSkillCheckBehavior(behavior);
    }

    private class DwarvenResilienceSkillCheckBehavior : ISavingThrowBehavior
    {
        private readonly ISavingThrowBehavior _savingThrowBehavior;

        public DwarvenResilienceSkillCheckBehavior(ISavingThrowBehavior savingThrowBehavior)
        {
            ArgumentNullException.ThrowIfNull(savingThrowBehavior);

            _savingThrowBehavior = savingThrowBehavior;
        }

        public Character Character => _savingThrowBehavior.Character;

        public ID20ThrowerBuilder Handel(SavingThrowAction action)
        {
            ArgumentNullException.ThrowIfNull(action);

            var d20ThrowerBuilder = _savingThrowBehavior.Handel(action);
            return action.Tags.Contains(Tage.Damage.Poison)
                ? new D20ThrowerModeWrapperBuilder(ThrowMode.Advantage, d20ThrowerBuilder)
                : d20ThrowerBuilder;
        }
    }
}
