using DnD.SRD.Actions;
using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Abilities.Behaviors;

public interface ISkillCheckBehavior
{
    Character Character { get; }

    ID20ThrowerBuilder Handel(ISkillCheckAction action);
}
