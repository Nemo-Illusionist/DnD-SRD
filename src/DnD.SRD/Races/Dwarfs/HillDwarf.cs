using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Dwarfs;

public sealed class HillDwarf : Dwarf
{
    public HillDwarf()
        : base(new Ability(
            strength: AbilityPoint.Empty,
            dexterity: AbilityPoint.Empty,
            constitution: AbilityPoint.Empty,
            intelligence: AbilityPoint.Empty,
            wisdom: new AbilityPoint(1),
            charisma: AbilityPoint.Empty))
    {
    }

    // Dwarven Toughness Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.
}
