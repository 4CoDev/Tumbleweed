namespace Tumbleweed.Delegates.Actions.Binary;

public class ActionFromSystem<T1, T2> : IAction<T1, T2>
{
	public ActionFromSystem(Action<T1, T2> action) =>
		this.action = action;

	public void InvokeWith(T1 first, T2 second) =>
		action(first, second);

	private readonly Action<T1, T2> action;
}