using Tumbleweed.Scalars;

namespace Tumbleweed.Actions;

public class ActionOfDelegate : IAction
{
	public ActionOfDelegate(Action action)
	{
		this.action = action;
	}
	
	public void Action()
	{
		action();
	}
	
	private readonly Action action;
}