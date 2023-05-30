using Tumbleweed.Scalar;

namespace Tumbleweed.Subroutine.Nullary.Action;

public class ActionFromSystem : IAction
{
	public ActionFromSystem(System.Action function) : this
	(
		new ScalarValue<System.Action>(function)
	)
	{
	}
	
	public ActionFromSystem(IScalar<System.Action> function) =>
		this.function = function;

	public void Invoke() =>
		function.Value();

	private readonly IScalar<System.Action> function;
}