namespace DnD.SRD.Abilities;

public sealed record Ability
{
    public Strength Strength { get; }
    public Dexterity Dexterity { get; }
    public Constitution Constitution { get; }
    public Intelligence Intelligence { get; }
    public Wisdom Wisdom { get; }
    public Charisma Charisma { get; }

    public Ability(
        Strength strength,
        Dexterity dexterity,
        Constitution constitution,
        Intelligence intelligence,
        Wisdom wisdom,
        Charisma charisma)
    {
        ArgumentNullException.ThrowIfNull(strength);
        ArgumentNullException.ThrowIfNull(dexterity);
        ArgumentNullException.ThrowIfNull(constitution);
        ArgumentNullException.ThrowIfNull(intelligence);
        ArgumentNullException.ThrowIfNull(wisdom);
        ArgumentNullException.ThrowIfNull(charisma);

        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }

    public static Ability operator +(Ability ability1, Ability ability2)
    {
        ArgumentNullException.ThrowIfNull(ability1);
        ArgumentNullException.ThrowIfNull(ability2);

        return new Ability(
            ability1.Strength + ability2.Strength,
            ability1.Dexterity + ability2.Dexterity,
            ability1.Constitution + ability2.Constitution,
            ability1.Intelligence + ability2.Intelligence,
            ability1.Wisdom + ability2.Wisdom,
            ability1.Charisma + ability2.Charisma
        );
    }
}
