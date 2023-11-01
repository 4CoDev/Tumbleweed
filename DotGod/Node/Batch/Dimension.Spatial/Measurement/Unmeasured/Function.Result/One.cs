using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary.From;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Function.Result;

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
		new Property.Value.One(
			new Actual<Any>(function))
	)
	{
	}
}