using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Mathematics.Boolean.System.Function.Result;

public sealed class Actual : Envelope<global::System.Boolean>
{
	public Actual
	(
		Func<global::System.Boolean> function
	) : this
	(
		new NullaryFunction.From.System<global::System.Boolean>(function)
	)
	{
	}
	
	public Actual
	(
		NullaryFunction.Any<global::System.Boolean> function
	) : base
	(
		new Actual<global::System.Boolean>(function)
	)
	{
	}
}