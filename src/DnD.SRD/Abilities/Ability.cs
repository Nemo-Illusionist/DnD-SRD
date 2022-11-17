namespace DnD.SRD.Abilities;

public sealed record Ability
{
    public AbilityPoint Strength { get; }
    public AbilityPoint Dexterity { get; }
    public AbilityPoint Constitution { get; }
    public AbilityPoint Intelligence { get; }
    public AbilityPoint Wisdom { get; }
    public AbilityPoint Charisma { get; }

    public Ability(
        AbilityPoint strength,
        AbilityPoint dexterity,
        AbilityPoint constitution,
        AbilityPoint intelligence,
        AbilityPoint wisdom,
        AbilityPoint charisma)
    {
        // todo: not null

        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }

    public static Ability operator +(Ability ability1, Ability ability2)
    {
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
