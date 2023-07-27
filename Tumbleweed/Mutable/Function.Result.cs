using Tumbleweed.Scalar.Function;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mutable.Function;

public sealed class Result<T> : Mutable.Envelope<T>
{
	public Result(Func<Mutable.Any<T>> function) : this
	(
		new NullaryFunction.From.System<Mutable.Any<T>>(function)
	)
	{
	}

	public Result(NullaryFunction.Any<Mutable.Any<T>> function) : base
	(
		new Mutable.ScalarValue<T>(
			new Scalar.Function.Result<Mutable.Any<T>>(function))
	)
	{
	}
}