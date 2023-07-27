using Tumbleweed.Event.Subscription.Scalar;
using Tumbleweed.Scalar.Function;
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
			new Tumbleweed.Scalar.Function.Result<Any<T>>(function))
	)
	{
	}
}