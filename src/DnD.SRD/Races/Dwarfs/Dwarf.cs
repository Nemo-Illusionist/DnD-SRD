using DnD.SRD.Abilities;
using DnD.SRD.Tags;
using DnD.SRD.Vision;

namespace DnD.SRD.Races.Dwarfs;

public abstract partial class Dwarf : Race
{
    protected Dwarf(Ability ability)
        : base(ability + new Ability(constitution: new Constitution(2)), 25)
    {
        Resistances = new[] { DamageType.Poison };
        Vision = new DarkVision();
    }

    public override IReadOnlyCollection<DamageType> Resistances { get; }
    public override IVision Vision { get; }

    // - Dwarven Combat Training: You have proficiency with the battleaxe, handaxe, light hammer, and warhammer.
    // - Tool Proficiency: You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.
}
