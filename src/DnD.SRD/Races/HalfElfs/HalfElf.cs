using DnD.SRD.Abilities;

namespace DnD.SRD.Races.HalfElfs;

public sealed class HalfElf : Race
{
    public HalfElf(AbilityType type1, AbilityType type2)
        : base(new Ability(
            strength: new Strength(IsBuild1(type1, type2, AbilityType.Strength)),
            dexterity: new Dexterity(IsBuild1(type1, type2, AbilityType.Dexterity)),
            constitution: new Constitution(IsBuild1(type1, type2, AbilityType.Constitution)),
            intelligence: new Intelligence(IsBuild1(type1, type2, AbilityType.Intelligence)),
            wisdom: new Wisdom(IsBuild1(type1, type2, AbilityType.Wisdom)),
            charisma: new Charisma(2)))
    {
    }

    private static int IsBuild1(AbilityType type1, AbilityType type2, AbilityType e)
        => type1 == e || type2 == e ? 1 : 0;

    // - Darkvision: Thanks to your elf blood, you have superior vision in dark and dim conditions.
    // You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.
    // You can’t discern color in darkness, only shades of gray.
    // - Fey Ancestry: You have advantage on saving throws against being charmed, and magic can’t put you to sleep.
    // - Skill Versatility: You gain proficiency in two skills of your choice.
}
