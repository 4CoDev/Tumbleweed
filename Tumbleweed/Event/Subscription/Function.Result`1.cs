using Tumbleweed.Event.Subscription.Scalar;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Subscription.Function;

public sealed class Result<T> : Envelope<T>
{
	public Result(Func<Any<T>> function) : this
	(
		new System<Any<T>>(function)
	)
	{
	}
	
	public Result
	(Subroutine.Function.Nullary.Any<Any<T>> function
	) : base
	(
		new Value<T>(
			new Actual<Any<T>>(function))
	)
	{
	}
}