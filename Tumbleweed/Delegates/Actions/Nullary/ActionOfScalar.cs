using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Actions.Nullary;

public sealed class ActionOfScalar : IAction
{
	public ActionOfScalar(IScalar<IAction> scalar) =>
		this.scalar = scalar;
	
	public void Invoke() =>
		scalar.Value.Invoke();
	
	private readonly IScalar<IAction> scalar;
}