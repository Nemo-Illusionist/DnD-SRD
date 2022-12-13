using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Dwarfs;

public sealed class HillDwarf : Dwarf
{
    public HillDwarf()
        : base(new Ability(wisdom: new Wisdom(1)))
    {
    }

    // Dwarven Toughness Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.
}
