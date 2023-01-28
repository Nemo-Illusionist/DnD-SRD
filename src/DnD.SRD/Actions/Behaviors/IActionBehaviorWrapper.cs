namespace DnD.SRD.Actions.Behaviors;

public interface IActionBehaviorWrapper<TActionBehavior> where TActionBehavior : IActionBehavior
{
    TActionBehavior Wrap(TActionBehavior behavior);
}
