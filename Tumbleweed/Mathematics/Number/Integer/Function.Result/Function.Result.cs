using Tumbleweed.Scalar.Immutable.Function.Result;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Mathematics.Number.Integer.Function.Result;

public sealed class Actual : Envelope
{
	public Actual(Func<Any> function) : this
	(
		new NullaryFunction.From.System<Any>(
			function)
	)
	{
	}
	
	public Actual(NullaryFunction.Any<Any> function) : base
	(
		new Scalar.Value.Actual(
			new Actual<Any>(function))
	)
	{
	}
}