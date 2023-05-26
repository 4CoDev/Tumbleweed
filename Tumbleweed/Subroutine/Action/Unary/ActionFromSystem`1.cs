namespace Tumbleweed.Subroutine.Action.Unary;

public class ActionFromSystem<T> : IAction<T>
{
	public ActionFromSystem(Action<T> action) =>
		this.action = action;

	public void InvokeWith(T parameter) =>
		action(parameter);

	private readonly Action<T> action;
}