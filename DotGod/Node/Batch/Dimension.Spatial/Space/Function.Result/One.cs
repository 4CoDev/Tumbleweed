using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Function.Result;

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
	(Tumbleweed.Subroutine.Function.Nullary.Any<Any> function
	) : base
	(
		new Scalar.Value.One(
			new Actual<Any>(
				function))
	)
	{
	}
}