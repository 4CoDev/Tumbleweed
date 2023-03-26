namespace Tumbleweed.Delegates.Actions.Binary;

public class ActionFromSystem<T1, T2> : IBinaryAction<T1, T2>
{
	public ActionFromSystem(Action<T1, T2> action) =>
		this.action = action;

	public void Invoke(T1 parameter1, T2 parameter2) =>
		action(parameter1, parameter2);

	private readonly Action<T1, T2> action;
}