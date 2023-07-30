using Tumbleweed.Scalar.Immutable.Function.Result;
using TW = Tumbleweed;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Natural.Function;

public sealed class Result : Natural.Envelope
{
	public Result
	(
		Func<Natural.Any> function
	) : this
	(
		new NullaryFunction.From.System<Natural.Any>(function)
	)
	{
	}
	
	public Result
	(
		NullaryFunction.Any<Natural.Any> function
	) : base
	(
		new Scalar.Value(
			new Actual<Natural.Any>(function))
	)
	{
	}
}