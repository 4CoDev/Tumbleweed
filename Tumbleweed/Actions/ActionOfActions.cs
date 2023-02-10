namespace Tumbleweed.Actions;

public sealed class ActionOfActions : ActionEnvelope
{
	public ActionOfActions(IEnumerable<IAction> actions) : base
	(
		new ActionOfDelegate(() => Result(actions))
	)
	{
	}
	
	private static void Result(IEnumerable<IAction> actions)
	{
		foreach (IAction action in actions) action.Action();
	}
}