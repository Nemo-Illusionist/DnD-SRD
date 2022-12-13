using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Gnomes;

public abstract class Gnome : Race
{
    protected Gnome(Ability ability)
        : base(ability + new Ability(intelligence: new Intelligence(2)), 25)
    {
    }

    // - Darkvision: Accustomed to life underground, you have superior vision in dark and dim conditions.
    // You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.
    // You can’t discern color in darkness, only shades of gray.
    // - Gnome Cunning: You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.
}
