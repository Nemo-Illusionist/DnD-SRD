using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Actions.Behaviors;

public abstract class BaseBehavior<TAction> where TAction : IAction
{
    protected BaseBehavior(Character character)
    {
        ArgumentNullException.ThrowIfNull(character);

        Character = character;
    }

    public Character Character { get; }

    public abstract ID20ThrowerBuilder Handel(TAction action);
}
