using DnD.SRD.Characters;
using DnD.SRD.Dices;

namespace DnD.SRD.Actions.Behaviors;

public abstract class BaseActionBehavior<TAction> : IActionBehavior where TAction : IAction
{
    protected BaseActionBehavior(Character character)
    {
        ArgumentNullException.ThrowIfNull(character);

        Character = character;
    }

    public Character Character { get; }

    public abstract ID20ThrowerBuilder Handel(TAction action);
}
