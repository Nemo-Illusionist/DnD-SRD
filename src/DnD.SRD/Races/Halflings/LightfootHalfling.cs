using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Halflings;

public sealed class LightfootHalfling : Halfling
{
    public LightfootHalfling()
        : base(new Ability(
            strength: new Strength(),
            dexterity: new Dexterity(),
            constitution: new Constitution(),
            intelligence: new Intelligence(),
            wisdom: new Wisdom(),
            charisma: new Charisma(1)))
    {
    }

    // Naturally Stealthy. You can attempt to hide even when you are obscured only by a creature that is at least one size larger than you.
}
