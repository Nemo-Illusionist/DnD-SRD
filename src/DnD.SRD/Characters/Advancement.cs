namespace DnD.SRD.Characters;

public sealed record Advancement
{
    public int Experience { get; }
    public int Level => CalculateLevel();
    public int ProficiencyBonus => (int)Math.Ceiling(Level / 4.0) + 1;

    public Advancement(int experience)
    {
        if (experience < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(experience));
        }

        Experience = experience;
    }

    public static Advancement operator +(Advancement point1, Advancement point2)
    {
        ArgumentNullException.ThrowIfNull(point1);
        ArgumentNullException.ThrowIfNull(point2);

        var experience = point1.Experience + point2.Experience;
        return new Advancement(experience);
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
