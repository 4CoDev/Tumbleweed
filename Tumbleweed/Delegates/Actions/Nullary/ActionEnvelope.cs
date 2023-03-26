namespace Tumbleweed.Delegates.Actions.Nullary;

public abstract class ActionEnvelope : INullaryAction
{
	protected ActionEnvelope(INullaryAction nullaryAction) =>
		this.nullaryAction = nullaryAction;
	
	public void Invoke() => nullaryAction.Invoke();

	private readonly INullaryAction nullaryAction;
}