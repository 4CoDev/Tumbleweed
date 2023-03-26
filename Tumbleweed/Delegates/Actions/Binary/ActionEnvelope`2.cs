namespace Tumbleweed.Delegates.Actions.Binary;

public abstract class ActionEnvelope<T1, T2> : IBinaryAction<T1, T2>
{
	protected ActionEnvelope(IBinaryAction<T1, T2> binaryAction) =>
		this.binaryAction = binaryAction;
	
	public void Invoke(T1 parameter1, T2 parameter2) =>
		binaryAction.Invoke(parameter1, parameter2);

	private readonly IBinaryAction<T1, T2> binaryAction;
}