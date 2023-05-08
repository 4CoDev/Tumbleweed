namespace Tumbleweed.Delegates.Actions.Nullary;

public abstract class ActionEnvelope : IAction
{
	protected ActionEnvelope(IAction action) =>
		this.action = action;
	
	public void Invoke() =>
		action.Invoke();

	private readonly IAction action;
}