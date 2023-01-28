using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Dwarfs;

public abstract partial class Dwarf : Race
{
    protected Dwarf(Ability ability)
        : base(ability + new Ability(constitution: new Constitution(2)), 25)
    {
    }

    public override IReadOnlyCollection<DamageType> Resistances { get; } = new[] { DamageType.Poison };

    // - Darkvision: Accustomed to life underground, you have superior vision in dark and dim conditions.
    // You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.
    // You can’t discern color in darkness, only shades of gray.
    // - Dwarven Combat Training: You have proficiency with the battleaxe, handaxe, light hammer, and warhammer.
    // - Tool Proficiency: You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.
}
