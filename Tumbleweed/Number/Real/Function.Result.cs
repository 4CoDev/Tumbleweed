using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Function;

public sealed class Result : Real.Envelope
{
	public Result(Func<Real.Any> function) : this
	(
		new NullaryFunction.From.System<Real.Any>(function)
	)
	{
	}
	
	public Result(NullaryFunction.Any<Real.Any> function) : base
	(
		new Real.Scalar.Value(
			new TW.Scalar.Function.Result<Real.Any>(function))
	)
	{
	}
}