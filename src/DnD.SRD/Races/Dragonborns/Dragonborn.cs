using DnD.SRD.Abilities;

namespace DnD.SRD.Races.Dragonborns;

public class Dragonborn : Race
{
    public Dragonborn(DraconicAncestry ancestry)
        : base(new Ability(
            strength: new Strength(2),
            dexterity: new Dexterity(),
            constitution: new Constitution(),
            intelligence: new Intelligence(),
            wisdom: new Wisdom(),
            charisma: new Charisma(1)))
    {
        Ancestry = ancestry;
        var resistance = Ancestry switch
        {
            DraconicAncestry.Black => DamageType.Acid,
            DraconicAncestry.Blue => DamageType.Lightning,
            DraconicAncestry.Brass => DamageType.Fire,
            DraconicAncestry.Bronze => DamageType.Lightning,
            DraconicAncestry.Copper => DamageType.Acid,
            DraconicAncestry.Gold => DamageType.Fire,
            DraconicAncestry.Green => DamageType.Poison,
            DraconicAncestry.Red => DamageType.Fire,
            DraconicAncestry.Silver => DamageType.Cold,
            DraconicAncestry.White => DamageType.Cold,
            _ => throw new ArgumentOutOfRangeException(nameof(ancestry), $"Not expected direction value: {ancestry}")
        };
        Resistances = new[] { resistance };
    }

    public DraconicAncestry Ancestry { get; }
    public override IReadOnlyCollection<DamageType> Resistances { get; }

    // todo: add Breath Weapon
    // Breath Weapon: You can use your action to exhale destructive energy.
    // Your draconic ancestry determines the size, shape, and damage type of the exhalation.
    //
    // When you use your breath weapon, each creature in the area of the exhalation must make a saving throw,
    // the type of which is determined by your draconic ancestry.
    // The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus.
    // A creature takes 2d6 damage on a failed save, and half as much damage on a successful one.
    // The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level.
}
