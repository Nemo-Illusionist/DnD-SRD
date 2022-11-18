using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Elfs;

public abstract class Elf : Race
{
    protected Elf(Ability ability)
        : base(ability + new Ability(
            strength: new Strength(),
            dexterity: new Dexterity(2),
            constitution: new Constitution(),
            intelligence: new Intelligence(),
            wisdom: new Wisdom(),
            charisma: new Charisma()))
    {
    }

    // - Darkvision: Accustomed to life underground, you have superior vision in dark and dim conditions.
    // You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.
    // You can’t discern color in darkness, only shades of gray.
    // - Keen Senses: You have proficiency in the Perception skill.
    // - Fey Ancestry: You have advantage on saving throws against being charmed, and magic can’t put you to sleep.
}
