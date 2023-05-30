using Tumbleweed._Enumerable;

namespace Tumbleweed.Subroutine.Nullary.Action;

public sealed class ActionOfActions : ActionEnvelope
{
	public ActionOfActions(params IAction[] actions) : this
	(
		new EnumerableWithElements<IAction>(actions)
	)
	{
	}
	
	public ActionOfActions(IEnumerable<IAction> actions) : base
	(
		new ActionFromSystem(() => Result(actions))
	)
	{
	}
	
	private static void Result(IEnumerable<IAction> actions)
	{
		foreach (IAction action in actions) action.Invoke();
	}
}