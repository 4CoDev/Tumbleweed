using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.Result.Of;

public sealed class Function : Batch.Envelope
{
	public Function
	(
		Func<Batch.Any> function
	) : this
	(
		new System<Batch.Any>(function)
	)
	{
	}
	
	public Function
	(
		NullaryFunction.Any<Batch.Any> function
	) : base
	(
		new Value.Of.Scalar(
			new Actual<Batch.Any>(function))
	)
	{
	}
}