// ReSharper disable once CheckNamespace

using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Nullary.From;

public class System : Nullary.Any
{
	public System(Action procedure) : this
	(
		new Value<Action>(procedure)
	)
	{
	}
	
	public System(Any<Action> function) =>
		this.function = function;

	public void Invoke() =>
		function.Value();

	private readonly Any<Action> function;
}