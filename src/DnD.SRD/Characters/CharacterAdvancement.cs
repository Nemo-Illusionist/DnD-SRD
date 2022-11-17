namespace DnD.SRD.Characters;

public sealed record CharacterAdvancement
{
    public int Experience { get; private init; }
    public int Level => CalculateLevel();
    public int ProficiencyBonus => (int)Math.Ceiling(Level / 4.0) + 1;

    public CharacterAdvancement(int experience)
    {
        Experience = experience;
    }


    public static CharacterAdvancement operator +(CharacterAdvancement point1, CharacterAdvancement point2)
    {
        var experience = point1.Experience + point2.Experience;
        return new CharacterAdvancement(experience);
    }

    private int CalculateLevel() => Experience switch
    {
        > 355000 => 20,
        > 305000 => 19,
        > 265000 => 18,
        > 225000 => 17,
        > 195000 => 16,
        > 165000 => 15,
        > 140000 => 14,
        > 120000 => 13,
        > 100000 => 12,
        > 85000 => 11,
        > 64000 => 10,
        > 48000 => 9,
        > 34000 => 8,
        > 23000 => 7,
        > 14000 => 6,
        > 6500 => 5,
        > 2700 => 4,
        > 900 => 3,
        > 300 => 2,
        > 0 => 1,
        _ => throw new ArgumentOutOfRangeException()
    };
}
