using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Scalar.Immutable.Function.Result;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Function;

public sealed class Result : Envelope
{
	public Result(Func<Any> function) : this
	(
		new NullaryFunction.From.System<Any>(function)
	)
	{
	}
	
	public Result(NullaryFunction.Any<Any> function) : base
	(
		new Real.Scalar.Value(
			new Actual<Any>(function))
	)
	{
	}
}