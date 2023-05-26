namespace Tumbleweed.Subroutine.Action.Unary;

public abstract class ActionEnvelope<T> : IAction<T>
{
	protected ActionEnvelope(IAction<T> action) =>
		this.action = action;
	
	public void InvokeWith(T parameter) =>
		action.InvokeWith(parameter);

	private readonly IAction<T> action;
}