namespace Tumbleweed.Subroutine.Action.Binary;

public abstract class ActionEnvelope<T1, T2> : IAction<T1, T2>
{
	protected ActionEnvelope(IAction<T1, T2> action) =>
		this.action = action;
	
	public void InvokeWith(T1 first, T2 second) =>
		action.InvokeWith(first, second);

	private readonly IAction<T1, T2> action;
}