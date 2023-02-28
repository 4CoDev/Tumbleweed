namespace Tumbleweed.Delegates.Actions.Nullary;

public abstract class ActionEnvelope : INullaryAction
{
	protected ActionEnvelope(INullaryAction nullaryAction) =>
		this.nullaryAction = nullaryAction;
	
	public void Invoke() => nullaryAction.Invoke();

	public override bool Equals(object? @object) =>
		nullaryAction.Equals(@object);

	public override int GetHashCode() =>
		nullaryAction.GetHashCode();

	public override string? ToString() =>
		nullaryAction.ToString();

	private readonly INullaryAction nullaryAction;
}