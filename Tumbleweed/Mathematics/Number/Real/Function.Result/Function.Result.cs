using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Scalar.Immutable.Function.Result;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using TW = Tumbleweed;

namespace Tumbleweed.Mathematics.Number.Real.Function.Result;

public sealed class Actual : Envelope
{
	public Actual(Func<Any> function) : this
	(
		new NullaryFunction.From.System<Any>(function)
	)
	{
	}
	
	public Actual(NullaryFunction.Any<Any> function) : base
	(
		new Real.Scalar.Value(
			new Actual<Any>(function))
	)
	{
	}
}