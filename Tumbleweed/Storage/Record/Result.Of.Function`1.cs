using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Storage.Record.Of;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Storage.Record.Result.Of;

public sealed class Function<T> : Record.Envelope<T> where T : notnull
{
	public Function
	(
		Func<Record.Any<T>> function
	) : this
	(
		new NullaryFunction.From.System<Record.Any<T>>(function)
	)
	{
	}
	
	public Function
	(
		NullaryFunction.Any<Record.Any<T>> function
	) : base
	(
		new Scalar<T>(
			new Actual<Record.Any<T>>(function))
	)
	{
	}
}