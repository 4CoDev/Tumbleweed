namespace Tumbleweed.Actions;

public abstract class ActionEnvelope : IAction
{
	protected ActionEnvelope(IAction action)
	{
		this.action = action;
	}
	
	public void Action()
	{
		action.Action();
	}
	
	private readonly IAction action;
}