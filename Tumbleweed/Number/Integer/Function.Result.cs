using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Integer.Function;

public sealed class Result : Integer.Envelope
{
	public Result(Func<Integer.Any> function) : this
	(
		new NullaryFunction.From.System<Integer.Any>(
			function)
	)
	{
	}
	
	public Result(NullaryFunction.Any<Integer.Any> function) : base
	(
		new Integer.Scalar.Value(
			new TW.Scalar.Function.Result<Integer.Any>(function))
	)
	{
	}
}