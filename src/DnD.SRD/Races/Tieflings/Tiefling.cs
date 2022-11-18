using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Tieflings;

public sealed class Tiefling : Race
{
    public Tiefling()
        : base(new Ability(
                strength: new Strength(),
                dexterity: new Dexterity(),
                constitution: new Constitution(),
                intelligence: new Intelligence(1),
                wisdom: new Wisdom(),
                charisma: new Charisma(2)))
    {
    }

    public override IReadOnlyCollection<DamageType> Resistances { get; } = new[] { DamageType.Fire };

    // - Darkvision: Thanks to your infernal heritage, you have superior vision in dark and dim conditions.
    // You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.
    // You can’t discern color in darkness, only shades of gray.
    // - Infernal Legacy. You know the thaumaturgy cantrip.
    // When you reach 3rd level, you can cast the hellish rebuke spell as a 2nd-level spell once with this trait and regain the ability to do so when you finish a long rest.
    // When you reach 5th level, you can cast the darkness spell once with this trait and regain the ability to do so when you finish a long rest.
    // Charisma is your spellcasting ability for these spells.
}
