using Tumbleweed.Enumerables;

namespace Tumbleweed.Delegates.Actions.Nullary;

public sealed class ActionOfActions : ActionEnvelope
{
	public ActionOfActions(params INullaryAction[] actions) : this
	(
		new EnumerableWithElements<INullaryAction>(actions)
	)
	{
	}
	
	public ActionOfActions(IEnumerable<INullaryAction> actions) : base
	(
		new ActionFromSystem(() => Result(actions))
	)
	{
	}
	
	private static void Result(IEnumerable<INullaryAction> actions)
	{
		foreach (INullaryAction action in actions) action.Invoke();
	}
}