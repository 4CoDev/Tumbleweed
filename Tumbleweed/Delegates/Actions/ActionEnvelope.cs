namespace Tumbleweed.Delegates.Actions;

public abstract class ActionEnvelope : IAction
{
	protected ActionEnvelope(IAction action)
	{
		this.action = action;
	}
	
	public void Action()
	{
		action.Action();
	}

	public override bool Equals(object? obj)
	{
		return action.Equals(obj);
	}

	public override int GetHashCode()
	{
		return action.GetHashCode();
	}

	public override string? ToString()
	{
		return action.ToString();
	}

	private readonly IAction action;
}