using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Halflings;

public sealed class LightfootHalfling : Halfling
{
    public LightfootHalfling()
        : base(new Ability(
            strength: AbilityPoint.Empty,
            dexterity: AbilityPoint.Empty,
            constitution: AbilityPoint.Empty,
            intelligence: AbilityPoint.Empty,
            wisdom: AbilityPoint.Empty,
            charisma: new AbilityPoint(1)))
    {
    }

    // Naturally Stealthy. You can attempt to hide even when you are obscured only by a creature that is at least one size larger than you.
}