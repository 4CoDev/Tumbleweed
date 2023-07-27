using Tumbleweed.String;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed._String.Function;

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
		new ScalarValue(
			new Scalar.Function.Result<Any>(function))
	)
	{
	}
}