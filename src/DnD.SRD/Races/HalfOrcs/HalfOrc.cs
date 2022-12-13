using DnD.SRD.Abilities;

namespace DnD.SRD.Races.HalfOrcs;

public sealed class HalfOrc : Race
{
    public HalfOrc()
        : base(new Ability(
            strength: new Strength(2),
            constitution: new Constitution(1),
            charisma: new Charisma(
                skillModes: new Dictionary<SkillType, SkillMode> { { SkillType.Intimidation, SkillMode.One } })))
    {
    }

    // - Darkvision: Thanks to your elf blood, you have superior vision in dark and dim conditions.
    // You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light.
    // You can’t discern color in darkness, only shades of gray.
    // - Menacing: You gain proficiency in the Intimidation skill.
    // - Relentless Endurance: When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead.
    // You can’t use this feature again until you finish a long rest.
    // - Savage Attacks: When you score a critical hit with a melee weapon attack,
    // you can roll one of the weapon’s damage dice one additional time and add it to the extra damage of the critical hit.
}
