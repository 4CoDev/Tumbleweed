using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Actions.Nullary;

public sealed class ActionOfScalar : INullaryAction
{
	public ActionOfScalar(IScalar<INullaryAction> scalar)
	{
		this.scalar = scalar;
	}
	
	public void Invoke() => scalar.Value.Invoke();
	
	private readonly IScalar<INullaryAction> scalar;
}