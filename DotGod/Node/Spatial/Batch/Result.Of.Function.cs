using DotGod.Node.Spatial.Batch;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.Result.Of;

public sealed class Function : Envelope
{
	public Function
	(
		Func<Any> function
	) : this
	(
		new System<Any>(function)
	)
	{
	}
	
	public Function
	(
		NullaryFunction.Any<Any> function
	) : base
	(
		new Value.Of.Scalar(
			new Actual<Any>(function))
	)
	{
	}
}