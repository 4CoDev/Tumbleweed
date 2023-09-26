using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Array.Item.Value.At.Index;

public sealed class One : Envelope
{
	public One
	(Tumbleweed.Array.Any<Any> array, Any<Tumbleweed.Mathematics.Number.Natural.Any> indices
	) : base
	(
		new Scalar.Value.One(
			new Tumbleweed.Scalar.Immutable.From.Array.Spatial.At.Index<Any>(
				array, 
				indices))
	)
	{
	}
}