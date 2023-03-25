namespace Tumbleweed.Delegates.Actions.Unary;

public abstract class ActionEnvelope<T> : IUnaryAction<T>
{
	protected ActionEnvelope(IUnaryAction<T> unaryAction) =>
		this.unaryAction = unaryAction;
	
	public void Invoke(T parameter) => unaryAction.Invoke(parameter);

	public override Boolean Equals(Object? @object) =>
		unaryAction.Equals(@object);

	public override Int32 GetHashCode() =>
		unaryAction.GetHashCode();

	public override String? ToString() =>
		unaryAction.ToString();

	private readonly IUnaryAction<T> unaryAction;
}