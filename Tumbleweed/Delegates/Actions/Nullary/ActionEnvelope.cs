namespace Tumbleweed.Delegates.Actions.Nullary;

public abstract class ActionEnvelope : INullaryAction
{
	protected ActionEnvelope(INullaryAction nullaryAction) =>
		this.nullaryAction = nullaryAction;
	
	public void Invoke() => nullaryAction.Invoke();

	public override Boolean Equals(Object? @object) =>
		nullaryAction.Equals(@object);

	public override Int32 GetHashCode() =>
		nullaryAction.GetHashCode();

	public override String? ToString() =>
		nullaryAction.ToString();

	private readonly INullaryAction nullaryAction;
}