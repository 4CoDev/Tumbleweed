using Tumbleweed.Boolean;
using Tumbleweed.Boolean.Scalar;
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Scalar.Immutable.Function.Result;
using TW = Tumbleweed;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Boolean.Function;

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
		new Value(
			new Actual<Any>(function))
	)
	{
	}
}