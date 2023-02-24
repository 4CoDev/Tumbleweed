using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Actions;

public sealed class ActionOfScalar : IAction
{
	public ActionOfScalar(IScalar<IAction> scalar)
	{
		this.scalar = scalar;
	}
	
	public void Action()
	{
		scalar.Value().Action();
	}
	
	private readonly IScalar<IAction> scalar;
}