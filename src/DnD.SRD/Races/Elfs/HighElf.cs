using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Elfs;

public sealed class HighElf : Elf
{
    public HighElf()
        : base(new Ability(intelligence: new Intelligence(1)))
    {
    }
    // - Elf Weapon Training: You have proficiency with the longsword, shortsword, shortbow, and longbow.
    // - Cantrip: You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.
}
