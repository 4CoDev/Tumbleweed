using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary.From;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced.Function.Result;

public sealed class One : Envelope
{
	public One
	(
		Func<Any> function
	) : this
	(
		new System<Any>(function)
	)
	{
	}
	
	public One
	(
		NullaryFunction.Any<Any> function
	) : base
	(
		new Scalar.Value.One(
			new Actual<Any>(function))
	)
	{
	}
}