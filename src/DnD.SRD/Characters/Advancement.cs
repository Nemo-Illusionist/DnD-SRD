namespace DnD.SRD.Characters;

public sealed record Advancement
{
    public Advancement() : this(0)
    {
    }

    public Advancement(int experience)
    {
        if (experience < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(experience));
        }

        Experience = experience;
    }

    internal Advancement(Advancement advancement1, Advancement advancement2)
    {
        ArgumentNullException.ThrowIfNull(advancement1);
        ArgumentNullException.ThrowIfNull(advancement2);

        Experience = advancement1.Experience + advancement2.Experience;
    }

    public int Experience { get; }

    public int GetLevel() => CalculateLevel();

    public int GetProficiencyBonus() => (int)Math.Ceiling(GetLevel() / 4.0) + 1;

    private int CalculateLevel() => Experience switch
    {
        >= 355000 => 20,
        >= 305000 => 19,
        >= 265000 => 18,
        >= 225000 => 17,
        >= 195000 => 16,
        >= 165000 => 15,
        >= 140000 => 14,
        >= 120000 => 13,
        >= 100000 => 12,
        >= 85000 => 11,
        >= 64000 => 10,
        >= 48000 => 9,
        >= 34000 => 8,
        >= 23000 => 7,
        >= 14000 => 6,
        >= 6500 => 5,
        >= 2700 => 4,
        >= 900 => 3,
        >= 300 => 2,
        >= 0 => 1,
        _ => throw new ArgumentOutOfRangeException(
            nameof(Experience),
            Experience,
            "The value must be greater than or equal to 0")
    };
}
