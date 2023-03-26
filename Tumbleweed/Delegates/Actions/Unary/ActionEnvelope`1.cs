namespace Tumbleweed.Delegates.Actions.Unary;

public abstract class ActionEnvelope<T> : IUnaryAction<T>
{
	protected ActionEnvelope(IUnaryAction<T> unaryAction) =>
		this.unaryAction = unaryAction;
	
	public void Invoke(T parameter) =>
		unaryAction.Invoke(parameter);

	private readonly IUnaryAction<T> unaryAction;
}