using Tumbleweed.Scalar.Function;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Nullable.Result.Of;

public sealed class Function<T> : Nullable.Envelope<T>
{
	public Function
	(
		Func<Nullable.Any<T>> function
	) : this
	(
		new System<Nullable.Any<T>>(function)
	)
	{
	}
	
	public Function
	(
		NullaryFunction.Any<Nullable.Any<T>> function
	) : base
	(
		new Nullable.Of.Scalar<T>(
			new Scalar.Function.Result<Any<T>>(function))
	)
	{
	}
}