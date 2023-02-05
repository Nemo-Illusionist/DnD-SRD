using DnD.SRD.Abilities;
using DnD.SRD.Vision;

namespace DnD.SRD.Races.Gnomes;

public abstract class Gnome : Race
{
    protected Gnome(Ability ability)
        : base(ability + new Ability(intelligence: new Intelligence(2)), 25)
    {
        Vision = new DarkVision();
    }

    public override IVision Vision { get; }

    // - Gnome Cunning: You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.
}
