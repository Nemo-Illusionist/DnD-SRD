using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Gnomes;

public sealed class RockGnome : Gnome
{
    public RockGnome()
        : base(new Ability(constitution: new Constitution(1)))
    {
    }

    // - Artificer’s Lore: Whenever you make an Intelligence (History) check related to magic items,
    // alchemical objects, or technological devices, you can add twice your proficiency bonus,
    // instead of any proficiency bonus you normally apply.
}
