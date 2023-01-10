using DnD.SRD.Characters;

namespace DnD.SRD.Actions.Behaviors;

public interface IActionBehavior
{
    Character Character { get; }
}