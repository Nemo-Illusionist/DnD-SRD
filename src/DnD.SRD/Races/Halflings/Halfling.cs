using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Halflings;

public abstract class Halfling : Race
{
    protected Halfling(Ability ability)
        : base(ability + new Ability(dexterity: new Dexterity(2)), 25)
    {
    }

    // - Lucky: When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll.
    // - Brave: You have advantage on saving throws against being frightened.
    // - Halfling Nimbleness: You can move through the space of any creature that is of a size larger than yours.
}
