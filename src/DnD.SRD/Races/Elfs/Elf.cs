using DnD.SRD.Abilities;
using DnD.SRD.Vision;

namespace DnD.SRD.Races.Elfs;

public abstract class Elf : Race
{
    protected Elf(Ability ability)
        : base(ability + new Ability(
            dexterity: new Dexterity(2),
            wisdom: new Wisdom(
                skillModes: new Dictionary<SkillType, SkillMode> { { SkillType.Perception, SkillMode.One } })))
    {
        Vision = new DarkVision();
    }

    public override IVision Vision { get; }

    // - Fey Ancestry: You have advantage on saving throws against being charmed, and magic can’t put you to sleep.
}
