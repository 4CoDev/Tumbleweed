using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Scalar.Immutable.Function.Result;
using TW = Tumbleweed;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Natural.Function;

public sealed class Result : Envelope
{
	public Result
	(
		Func<Any> function
	) : this
	(
		new NullaryFunction.From.System<Any>(function)
	)
	{
	}
	
	public Result
	(
		NullaryFunction.Any<Any> function
	) : base
	(
		new Scalar.Value(
			new Actual<Any>(function))
	)
	{
	}
}