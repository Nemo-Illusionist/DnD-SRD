using DnD.SRD.Abilities;

namespace DnD.SRD.Races.HalfElfs;

public sealed class HalfElf : Race
{
    public HalfElf(AbilityPointType ability1, AbilityPointType ability2, SkillType skill1, SkillType skill2)
        : this(
            ability1,
            ability2,
            new Dictionary<SkillType, SkillMode> { { skill1, SkillMode.One }, { skill2, SkillMode.One } })
    {
    }

    private HalfElf(
        AbilityPointType ability1,
        AbilityPointType ability2,
        IReadOnlyDictionary<SkillType, SkillMode> skillModes)
        : base(new Ability(
            strength: new Strength(
                score: IsBuild1(ability1, ability2, AbilityPointType.Strength),
                skillModes: skillModes),
            dexterity: new Dexterity(
                score: IsBuild1(ability1, ability2, AbilityPointType.Dexterity),
                skillModes: skillModes),
            constitution: new Constitution(IsBuild1(ability1, ability2, AbilityPointType.Constitution)),
            intelligence: new Intelligence(
                score: IsBuild1(ability1, ability2, AbilityPointType.Intelligence),
                skillModes: skillModes),
            wisdom: new Wisdom(
                score: IsBuild1(ability1, ability2, AbilityPointType.Wisdom),
                skillModes: skillModes),
            charisma: new Charisma(
                score: 2,
                skillModes: skillModes)))
    {
    }

    private static int IsBuild1(AbilityPointType type1, AbilityPointType type2, AbilityPointType e)
        => type1 == e || type2 == e ? 1 : 0;

    // - Darkvision: Thanks to your elf blood, you have superior vision in dark and dim conditions.
    // You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.
    // You can’t discern color in darkness, only shades of gray.
    // - Fey Ancestry: You have advantage on saving throws against being charmed, and magic can’t put you to sleep.
    // - Skill Versatility: You gain proficiency in two skills of your choice.
}
