using DnD.SRD.Abilities;
using DnD.SRD.Abilities.Actions;
using DnD.SRD.Abilities.Behaviors;
using DnD.SRD.Races;

namespace DnD.SRD.Characters;

public sealed class Character
{
    public Character(
        Ability ability,
        Race race)
    {
        Ability = ability;
        Race = race;
        Advancement = new Advancement();
    }

    public Advancement Advancement { get; }
    public Ability Ability { get; }
    public Race Race { get; }

    public Ability GetCharacterAbility()
    {
        return Ability + Race.Ability;
    }

    public void SkillCheck(ISkillCheckAction action)
    {
        ISkillCheckBehavior handler = new SkillCheckBehavior(this);
        handler = Race.SkillCheckBehaviorWrap(handler);
    }
}
