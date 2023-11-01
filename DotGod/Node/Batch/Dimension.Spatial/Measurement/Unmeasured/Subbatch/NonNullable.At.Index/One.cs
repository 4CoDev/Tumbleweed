using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.NonNullable.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any batch,
		Any<Tumbleweed.Mathematics.Number.Natural.Any> index
	) : base
	(
		new Property.Value.One(
			new Nullable.At.Index.One(batch, index))
	)
	{
	}
}