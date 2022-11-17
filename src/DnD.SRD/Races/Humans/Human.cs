using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Humans;

public sealed class Human : Race
{
    public Human()
        : base(new Ability(
                strength: new AbilityPoint(1),
                dexterity: new AbilityPoint(1),
                constitution: new AbilityPoint(1),
                intelligence: new AbilityPoint(1),
                wisdom: new AbilityPoint(1),
                charisma: new AbilityPoint(1)),
            30)
    {
    }
}
