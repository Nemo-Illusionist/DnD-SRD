using DnD.SRD.Abilities;
using DnD.SRD.Tags;
using DnD.SRD.Vision;

namespace DnD.SRD.Races.Tieflings;

public sealed class Tiefling : Race
{
    public Tiefling()
        : base(new Ability(intelligence: new Intelligence(1), charisma: new Charisma(2)))
    {
        Resistances = new[] { DamageType.Fire };
        Vision = new DarkVision();
    }

    public override IReadOnlyCollection<DamageType> Resistances { get; }
    public override IVision Vision { get; }

    // - Infernal Legacy. You know the thaumaturgy cantrip.
    // When you reach 3rd level, you can cast the hellish rebuke spell as a 2nd-level spell once with this trait and regain the ability to do so when you finish a long rest.
    // When you reach 5th level, you can cast the darkness spell once with this trait and regain the ability to do so when you finish a long rest.
    // Charisma is your spellcasting ability for these spells.
}
