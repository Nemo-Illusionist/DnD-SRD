using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Humans;

public sealed class Human : Race
{
    public Human()
        : base(new Ability(
                strength: new Strength(1),
                dexterity: new Dexterity(1),
                constitution: new Constitution(1),
                intelligence: new Intelligence(1),
                wisdom: new Wisdom(1),
                charisma: new Charisma(1)))
    {
    }
}
