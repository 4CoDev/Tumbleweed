// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Nullary.From;

public class System : Nullary.Any
{
	public System(Action procedure) : this
	(
		new Scalar.Of.Value<Action>(procedure)
	)
	{
	}
	
	public System(Scalar.Any<Action> function) =>
		this.function = function;

	public void Invoke() =>
		function.Value();

	private readonly Scalar.Any<Action> function;
}