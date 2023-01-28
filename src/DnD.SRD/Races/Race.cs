using DnD.SRD.Abilities;

namespace DnD.SRD.Races;

public abstract class Race
{
    public Ability Ability { get; }
    public int Speed { get; }

    protected Race(Ability ability, int speed = 30)
    {
        Ability = ability;
        Speed = speed;
    }

    public virtual IReadOnlyCollection<DamageType> Resistances => Array.Empty<DamageType>();
}
