using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Array.Item.Value.At.Index;

public sealed class One : Envelope
{
	public One
	(Tumbleweed.Array.Dimension.Multi.Any<Any> array, Any<Tumbleweed.Mathematics.Number.Natural.Any> indices
	) : base
	(
		new Property.Value.One(
			new Tumbleweed.Property.Output.From.Array.Spatial.At.Index<Any>(
				array, 
				indices))
	)
	{
	}
}